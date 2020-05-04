using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;


// Test Code for Mate 2020 ROV 
// Corbin Ortolan


namespace PhotoMosaic
{
    public partial class Form1 : Form
    {
        //---------Initial Setup
        //video capture setup
        private VideoCapture _capture;
        private Thread _captureThread;

        // Global Variables
        private Image <Bgr,byte>[] sidesPictures = new Image<Bgr,byte>[5];
        private int count = 0;
        private int _whiteUpper = 255;
        private int _whiteLower = 100;
        private Image<Bgr, byte> warpedImage;
        public Image<Bgr, byte> WarpedImage
        {
            get => warpedImage;
            set
            {
                warpedImage = value;
                ThreshBox.Image = value.Bitmap;
            }
        }

        public Form1()
        {
            InitializeComponent();
            //---------Start Video Capture 
            _capture = new VideoCapture(1); // add 1 to make webcame
            _captureThread = new Thread(DisplayWebcam);
            _captureThread.Start();
        }

        private void DisplayWebcam()
        {
            while (_capture.IsOpened)
            {
                Mat frame = _capture.QueryFrame();

                // resize to PictureBox aspect ratio
                int newHeight = (frame.Size.Height * LiveFeedBox.Size.Width) / frame.Size.Width;
                Size newSize = new Size(LiveFeedBox.Size.Width, newHeight);
                CvInvoke.Resize(frame, frame, newSize);

                Image<Bgr, Byte> img = frame.ToImage<Bgr, Byte>();
                LiveFeedBox.Image = img.Bitmap;
                
                Image<Bgr, byte> sourceFrameWarped = frame.ToImage<Bgr, byte>();
                // Isolating the ROI: convert to a gray, apply binary threshold:
                Image<Gray, byte> grayImg = frame.ToImage<Gray, byte>().ThresholdBinary(new Gray(125), new
                Gray(255));
                using (VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint())
                {
                    // Build list of contours
                    CvInvoke.FindContours(grayImg, contours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);
                    // Selecting largest contour
                    if (contours.Size > 0)
                    {
                        double maxArea = 0;
                        int chosen = 0;
                        for (int i = 0; i < contours.Size; i++)
                        {
                            VectorOfPoint contour = contours[i];
                            double area = CvInvoke.ContourArea(contour);
                            if (area > maxArea)
                            {
                                maxArea = area;
                                chosen = i;
                            }
                        }
                        // Getting minimal rectangle which contains the contour
                        Rectangle boundingBox = CvInvoke.BoundingRectangle(contours[chosen]);
                       // Create a slightly larger bounding rectangle, we'll set it as the ROI for later warping
                        sourceFrameWarped.ROI = new Rectangle((int)Math.Min(0, boundingBox.X - 30),
                        (int)Math.Min(0, boundingBox.Y - 30),
                        (int)Math.Max(sourceFrameWarped.Width - 1, boundingBox.X +
                        boundingBox.Width + 30),
                        (int)Math.Max(sourceFrameWarped.Height - 1, boundingBox.Y +
                        boundingBox.Height + 30));
                        // Warp the image, output it
                        WarpedImage = WarpImage(sourceFrameWarped, contours[chosen]);
                    }
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BoxL0.BackColor = Color.Red;
            
            // Clear Debug Images
            Side0.Image = null;
            Side1.Image = null;
            Side2.Image = null;
            Side3.Image = null;
            Side4.Image = null;

            // Define Size Mode
            FinalBox.SizeMode = PictureBoxSizeMode.StretchImage;
           
            //---------Initialize Trackbars 
            //TB 1 == Lower Threshold 
            trackBar1.Maximum = 255;
            trackBar1.TickFrequency = 5;
            trackBar1.LargeChange = 3;
            trackBar1.SmallChange = 1;
            trackBar1.Value = _whiteUpper;
            //TB 2 == Upper Threshold
            trackBar2.Maximum = 255;
            trackBar2.TickFrequency = 5;
            trackBar2.LargeChange = 3;
            trackBar2.SmallChange = 1;
            trackBar2.Value = _whiteLower;
            //Set Intial Values of Trackbars
            Invoke(new Action(() =>
            {
                textBox1.Text = _whiteUpper.ToString();
                textBox2.Text = _whiteLower.ToString();
            }));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Close threads on form closing
            _captureThread.Abort();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                count = 4;
            }
            else
            {
                count -= 1;
            }

            switch(count)
            {
                case 0:
                    BoxL0.BackColor = Color.Red;
                    BoxL1.BackColor = Color.Empty;
                    break;

                case 1:
                    BoxL1.BackColor = Color.Red;
                    BoxL2.BackColor = Color.Empty;
                    break;

                case 2:
                    BoxL2.BackColor = Color.Red;
                    BoxL3.BackColor = Color.Empty;
                    break;

                case 3:
                    BoxL3.BackColor = Color.Red;
                    BoxL4.BackColor = Color.Empty;
                    break;

                case 4:
                    BoxL4.BackColor = Color.Red;
                    BoxL0.BackColor = Color.Empty;
                    break;
            }
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            moveForward();
        }

        private void moveForward()
        {
            if (count == 4)
            {
                count = 0;
            }
            else
            {
                count += 1;
            }

            switch (count)
            {
                case 0:
                    BoxL0.BackColor = Color.Red;
                    BoxL4.BackColor = Color.Empty;
                    break;

                case 1:
                    BoxL1.BackColor = Color.Red;
                    BoxL0.BackColor = Color.Empty;
                    break;

                case 2:
                    BoxL2.BackColor = Color.Red;
                    BoxL1.BackColor = Color.Empty;
                    break;

                case 3:
                    BoxL3.BackColor = Color.Red;
                    BoxL2.BackColor = Color.Empty;
                    break;

                case 4:
                    BoxL4.BackColor = Color.Red;
                    BoxL3.BackColor = Color.Empty;
                    break;
            }
        }

        private void TakePhotoButton_Click(object sender, EventArgs e)
        {
            switch (count)
            {
                case 0:                   
                    Side0.Image = ThreshBox.Image;
                    sidesPictures[count] = warpedImage;
                    break;
                case 1:
                    Side1.Image = ThreshBox.Image;
                    sidesPictures[count] = warpedImage;
                    break;
                case 2:
                    Side2.Image = ThreshBox.Image;
                    sidesPictures[count] = warpedImage.Resize(warpedImage.Width/2, warpedImage.Height, Inter.Cubic);
                    break;
                case 3:
                    Side3.Image = ThreshBox.Image;
                    sidesPictures[count] = warpedImage;
                    break;
                case 4:
                    Side4.Image = ThreshBox.Image;
                    sidesPictures[count] = warpedImage.Resize(warpedImage.Width / 2, warpedImage.Height, Inter.Cubic);
                    break;
            }
            moveForward(); // Move to next side
        }

        private void StitchButton_Click(object sender, EventArgs e)
        {
            // Make Bitmap Apropriate Size 
            int finalHeight = sidesPictures[0].Height + sidesPictures[1].Height;
            int finalWidth = 0;
            for (int i=1; i<5; i++)
            {
                finalWidth += sidesPictures[i].Width;
            }
            Bitmap StitchedImage = new Bitmap(finalWidth, finalHeight);
  
            // Add Images in Apropriate Areas
            using (Graphics g = Graphics.FromImage(StitchedImage))
            {
                g.DrawImage(sidesPictures[4].Bitmap, 0, sidesPictures[1].Height); // Small Side Left
                g.DrawImage(sidesPictures[1].Bitmap, sidesPictures[4].Width, sidesPictures[1].Height); // Long Side Center
                g.DrawImage(sidesPictures[2].Bitmap, sidesPictures[4].Width + sidesPictures[1].Width, sidesPictures[1].Height); // Small Side Right
                g.DrawImage(sidesPictures[3].Bitmap, sidesPictures[4].Width + sidesPictures[1].Width + sidesPictures[2].Width, sidesPictures[1].Height); // Long Side Right
                g.DrawImage(sidesPictures[0].Bitmap, sidesPictures[4].Width, 0); //Top
            }

            // Resize and Display
            Image<Bgr, Byte> finalImg = new Image<Bgr, byte>(StitchedImage);
            FinalBox.Image = finalImg.Bitmap;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // Display the trackbar value in the text box.
            textBox1.Text = "" + trackBar1.Value;
            _whiteUpper = trackBar1.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            // Display the trackbar value in the text box.
            textBox2.Text = "" + trackBar2.Value;
            _whiteLower = trackBar2.Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //do nothing atm
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // do nothing atm
        }

        //Image Warping
        private static Image<Bgr, Byte> WarpImage(Image<Bgr, byte> frame, VectorOfPoint contour)
        {
            // set the output size:
            var size = new Size(frame.Width, frame.Height);

            using (VectorOfPoint approxContour = new VectorOfPoint())
            {
                CvInvoke.ApproxPolyDP(contour, approxContour, CvInvoke.ArcLength(contour, true) * 0.05, true);
                // get an array of points in the contour
                Point[] points = approxContour.ToArray();
                // if array length isn't 4, something went wrong, abort warping process (for demo, draw points instead)
                if (points.Length != 4)
                {
                    for (int i = 0; i < points.Length; i++)
                    {
                        frame.Draw(new CircleF(points[i], 5), new Bgr(Color.Red), 5);
                    }
                    return frame;
                }
                IEnumerable<Point> query = points.OrderBy(point => point.Y).ThenBy(point => point.X);
                PointF[] ptsSrc = new PointF[4];
                PointF[] ptsDst = new PointF[] { new PointF(0, 0), new PointF(size.Width - 1, 0), new PointF(0, size.Height - 1),
                new PointF(size.Width - 1, size.Height - 1) };
                for (int i = 0; i < 4; i++)
                {
                    ptsSrc[i] = new PointF(query.ElementAt(i).X, query.ElementAt(i).Y);
                }
                using (var matrix = CvInvoke.GetPerspectiveTransform(ptsSrc, ptsDst))
                {
                    using (var cutImagePortion = new Mat())
                    {
                        CvInvoke.WarpPerspective(frame, cutImagePortion, matrix, size, Inter.Cubic);
                        return cutImagePortion.ToImage<Bgr, Byte>();
                    }
                }
            }
        }
    }
}