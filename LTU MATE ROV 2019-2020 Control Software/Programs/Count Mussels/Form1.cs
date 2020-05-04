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


namespace CountObjects
{

    public partial class Form1 : Form
    {
        //---------Initial Setup
        //video capture setup
        private VideoCapture _capture;
        private Thread _captureThread;

        private int height = 0;
        private int width = 0;
        private int mussels = 0;
        

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
                int newHeight = (frame.Size.Height * pictureBox1.Size.Width) / frame.Size.Width;
                Size newSize = new Size(pictureBox1.Size.Width, newHeight);
                CvInvoke.Resize(frame, frame, newSize);

                Image<Gray, byte> grayImg = frame.ToImage<Gray, byte>().ThresholdBinary(new Gray(125), new
               Gray(255)).Erode(3).Dilate(1);
                using (VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint())
                {
                    // Build list of contours
                    CvInvoke.FindContours(grayImg, contours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);

                    int num_O = contours.Size - 1; // it ounts the frame as 1 contour so we subtract it
                    label1.Invoke(new Action(() => {
                        label1.Text = "Mussels:  " + num_O.ToString();
                        mussels = num_O;
                        calculateFilteredAmount(height, width, num_O);
                    }));


                }

                pictureBox1.Image = grayImg.Bitmap;

            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int stringToInt;
            if (Int32.TryParse(textBox1.Text, out stringToInt))
            {
                height = stringToInt;
                calculateFilteredAmount(height, width, mussels);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int stringToInt;
            if (Int32.TryParse(textBox2.Text, out stringToInt))
            {
                width = stringToInt;
                calculateFilteredAmount(height, width, mussels);
            }

        }

        private void calculateFilteredAmount(int h, int w, int mussels)
        {
            double area = h*w;
            double musselT = Math.Ceiling((area / .25) * mussels);
            label5.Text = "Water Filtered(L / hr): " + (musselT *0.97).ToString();
        }
    }
}
