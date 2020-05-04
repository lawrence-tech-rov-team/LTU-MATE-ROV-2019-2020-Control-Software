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
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;

namespace Transect_Line_Code
{
    public partial class Form1 : Form
    {
        //---------Initial Setup
        //video capture setup

        private int count = 0;
        private int start = 0;
        private int end = 0;
        private List<Thresholds> colorThresholds = new List<Thresholds>();


        List<Shape> LastPosition = new List<Shape>();
        char[] key = new char[21];

        public class Thresholds
        {
            public double h_Upper;
            public double s_Upper;
            public double v_Upper;
            public double h_Lower;
            public double s_Lower;
            public double v_Lower;
        }

        public class Shape
        {
            public double x_Center;
            public double y_Center;
            public double area;
        }

		private Func<long, bool> Sleep;
		private Action<Twist> SetInput;
		private Func<Mat> ReadCamera1;
		private Func<Mat> ReadCamera2;

		public Form1(Func<long, bool> Sleep, Action<Twist> SetInput, Func<Mat> ReadCamera1, Func<Mat> ReadCamera2) {
            InitializeComponent();
			this.Sleep = Sleep;
			this.SetInput = SetInput;
			this.ReadCamera1 = ReadCamera1;
			this.ReadCamera2 = ReadCamera2;
        }

		public void DisplayWebcam(popup popup) {
			while (true) { 
				Mat frame = ReadCamera1();
				int largestCircle = 0;
				List<Shape> foundShape = new List<Shape>();
				List<char> shapeType = new List<char>();


				// resize to PictureBox aspect ratio
				int newHeight = (frame.Size.Height * pictureBox0.Size.Width) / frame.Size.Width;
				Size newSize = new Size(pictureBox0.Size.Width, newHeight);
				CvInvoke.Resize(frame, frame, newSize);

				Image<Hsv, Byte> img = frame.ToImage<Hsv, Byte>();
				Image<Gray, byte> coralNestImg = frame.ToImage<Gray, Byte>();
				Image<Gray, byte> coralOutcropImg = frame.ToImage<Gray, Byte>();
				Image<Gray, byte> starfishImg = frame.ToImage<Gray, Byte>();
				Image<Bgr, byte> drawnImage = frame.ToImage<Bgr, byte>();
				Image<Bgr, byte> coralNestDrawn = frame.ToImage<Bgr, byte>();
				Image<Bgr, byte> coralOutcropDrawn = frame.ToImage<Bgr, byte>();
				Image<Bgr, byte> starfishDrawn = frame.ToImage<Bgr, byte>();
				Image<Gray, byte> gridImg = frame.ToImage<Gray, Byte>();
				Image<Bgr, byte> gridDrawn = frame.ToImage<Bgr, byte>();

				//Line Follow 
				Hsv T_Lower = new Hsv(colorThresholds[4].h_Lower, colorThresholds[4].s_Lower, colorThresholds[4].v_Lower);
				Hsv T_Upper = new Hsv(colorThresholds[4].h_Upper, colorThresholds[4].s_Upper, colorThresholds[4].v_Upper);
				Image<Gray, byte> laneImg = frame.ToImage<Gray, Byte>();
				laneImg = img.InRange(T_Lower, T_Upper).Erode(2).Dilate(2);

				//count for columbs 
				int leftC = 0;
				int centerC = 0;
				int rightC = 0;


				for (int i = (laneImg.Height / 20) * 15; i < laneImg.Height; i++) {
					for (int j = (laneImg.Width / 20) * 14; j < (laneImg.Width / 20) * 16; j++) {
						//left
						if (laneImg.Data[i, j, 0] == 255) {
							leftC++;
						}
					}
					for (int j = (laneImg.Width / 20) * 16; j < (laneImg.Width / 20) * 18; j++) {
						//center
						if (laneImg.Data[i, j, 0] == 255) {
							centerC++;
						}
					}
					for (int j = (laneImg.Width / 20) * 18; j < (laneImg.Width / 20) * 20; j++) {
						//right
						if (laneImg.Data[i, j, 0] == 255) {
							rightC++;
						}
					}
				}

				if (leftC > centerC && leftC > rightC) {
					//twist left
					Twist twist = new Twist();
					twist.Linear.Z = 1f;
					SetInput(twist);
					label7.Invoke(new Action(() => {
						label7.Text = "left";
					}));
				} else {
					if (centerC > rightC && centerC > leftC) {
						// twist center
						Twist twist = new Twist();
						twist.Linear.X = 1f;
						SetInput(twist);
						label7.Invoke(new Action(() => {
							label7.Text = "center";
						}));
					} else {
						//twist right
						Twist twist = new Twist();
						twist.Linear.Z = -1f;
						SetInput(twist);

						label7.Invoke(new Action(() => {
							label7.Text = "right";
						}));
					}
				}

				if (leftC + rightC + centerC <= 100) {
					Twist twist = new Twist();
					twist.Linear.X = 0;
					SetInput(twist);
					//Update keys
					popup.UpdateKeys(key);
				}

				// Find Centers and Draw Bounding Rectangle 
				for (int i = 0; i < 3; i++) {
					VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
					List<Shape> shapes = new List<Shape>();
					Mat draw = new Mat();
					Hsv t_Lower = new Hsv(colorThresholds[i].h_Lower, colorThresholds[i].s_Lower, colorThresholds[i].v_Lower);
					Hsv t_Upper = new Hsv(colorThresholds[i].h_Upper, colorThresholds[i].s_Upper, colorThresholds[i].v_Upper);
					int shapeIndex = 0;
					double largestArea = 0;
					switch (i) {
						case 0:
							coralNestImg = img.InRange(t_Lower, t_Upper).Erode(2).Dilate(2);
							CvInvoke.FindContours(coralNestImg, contours, draw, Emgu.CV.CvEnum.RetrType.Ccomp, ChainApproxMethod.ChainApproxSimple);
							break;
						case 1:
							coralOutcropImg = img.InRange(t_Lower, t_Upper).Erode(2).Dilate(2);
							CvInvoke.FindContours(coralOutcropImg, contours, draw, Emgu.CV.CvEnum.RetrType.Ccomp, ChainApproxMethod.ChainApproxSimple);
							break;
						case 2:
							starfishImg = img.InRange(t_Lower, t_Upper).Erode(2).Dilate(2);
							CvInvoke.FindContours(starfishImg, contours, draw, Emgu.CV.CvEnum.RetrType.Ccomp, ChainApproxMethod.ChainApproxSimple);
							break;
						default:
							break;
					}


					for (int j = 0; j < contours.Size; j++) {
						double peramiter = CvInvoke.ArcLength(contours[j], true);
						VectorOfPoint positions = new VectorOfPoint();
						CvInvoke.ApproxPolyDP(contours[j], positions, 0.03 * peramiter, true);
						var moments = CvInvoke.Moments((contours[j]));
						shapes.Add(new Shape());
						//Find Centroid of shape and area and store in shape class
						shapes[j].x_Center = (moments.M10 / moments.M00);
						shapes[j].y_Center = (moments.M01 / moments.M00);
						shapes[j].area = CvInvoke.ContourArea(contours[j]);
					}
					//Only compute if there are shapes on screen
					if (shapes.Count > 0) {
						// find largest shape sstore it
						for (int j = 0; j < shapes.Count; j++) {
							if (shapes[j].area > largestArea) {
								largestArea = shapes[j].area;
								shapeIndex = j;
							}
						}


						Rectangle boundingRect = new Rectangle((int)(shapes[shapeIndex].x_Center - 50), (int)(shapes[shapeIndex].y_Center - 50), 100, 100);
						switch (i) {
							case 0:
								coralNestDrawn = coralNestImg.Convert<Bgr, byte>();
								coralNestDrawn.Draw(boundingRect, new Bgr(0, 0, 255), 3, LineType.EightConnected, 0);
								//Add to list of shapes found
								foundShape.Add(shapes[shapeIndex]);
								shapeType.Add('n');
								break;
							case 1:
								coralOutcropDrawn = coralOutcropImg.Convert<Bgr, byte>();
								coralOutcropDrawn.Draw(boundingRect, new Bgr(0, 0, 255), 3, LineType.EightConnected, 0);
								//Add to list of shapes found
								foundShape.Add(shapes[shapeIndex]);
								shapeType.Add('o');
								break;
							case 2:
								starfishDrawn = starfishImg.Convert<Bgr, byte>();
								starfishDrawn.Draw(boundingRect, new Bgr(0, 0, 255), 3, LineType.EightConnected, 0);
								//Add to list of shapes found
								foundShape.Add(shapes[shapeIndex]);
								shapeType.Add('s');
								break;
						}
					}

				}
				//Circle Detection
				/*     //    var findEdges = img.SmoothGaussian((int)(colorThresholds[3].h_Upper)).Convert<Gray, byte>().ThresholdBinaryInv(new Gray(colorThresholds[3].s_Lower), new Gray(colorThresholds[3].s_Upper)).Erode((int)(colorThresholds[3].h_Lower)).Dilate((int)(colorThresholds[3].h_Lower));

					 Hsv c_Lower = new Hsv(colorThresholds[3].h_Lower, colorThresholds[3].s_Lower, colorThresholds[3].v_Lower);
					 Hsv c_Upper = new Hsv(colorThresholds[3].h_Upper, colorThresholds[3].s_Upper, colorThresholds[3].v_Upper);
					 Image<Gray, byte> findEdges = frame.ToImage<Gray, Byte>();
					 findEdges = img.InRange(c_Lower, c_Upper).Erode(2);

					 Gray cannyThreshold = new Gray(180);
						 Gray cannyThresholdLinking = new Gray(120);
						 Gray circleAccumulatorThreshold = new Gray(60);

						 CircleF[] foundCircles = findEdges.HoughCircles(
							 cannyThreshold,
							 circleAccumulatorThreshold,
							 4.0, //Resolution of the accumulator used to detect centers of the circles
							 4.0, //Resolution of the accumulator used to detect centers of the circles
							 10.0, //min distance 
							 10, //min radius
							 30 //max radius
							 )[0]; //Get the circles from the first channel

						 drawnImage = findEdges.Convert<Bgr, Byte>();


						 // Find Largest Circle and Draw it on Frame
						 for (int j = 0; j < foundCircles.Length; j++)
						 {
							 if (j == 0)
							 {
								 // Skip 0 because its the largest circle at this time
							 }
							 else
							 {
								 if (foundCircles[j].Area > foundCircles[largestCircle].Area) // Check to see if this is the Largest Circle
								 {
									 largestCircle = j;
								 }
							 }
						 }
						 if (foundCircles.Length != 0)
							 drawnImage.Draw(foundCircles[largestCircle], new Bgr(0, 255, 0), 3, LineType.EightConnected, 0); // Circle Draw

					 */


				// Grid Detection
				VectorOfVectorOfPoint Contours = new VectorOfVectorOfPoint();
				Mat Draw = new Mat();
				Hsv g_Lower = new Hsv(colorThresholds[5].h_Lower, colorThresholds[5].s_Lower, colorThresholds[5].v_Lower);
				Hsv g_Upper = new Hsv(colorThresholds[5].h_Upper, colorThresholds[5].s_Upper, colorThresholds[5].v_Upper);
				gridImg = img.InRange(g_Lower, g_Upper).Erode(2).Dilate(2);
				CvInvoke.FindContours(coralNestImg, Contours, Draw, Emgu.CV.CvEnum.RetrType.Ccomp, ChainApproxMethod.ChainApproxSimple);
				List<Shape> gShapes = new List<Shape>();
				for (int j = 0; j < Contours.Size; j++) {
					double peramiter = CvInvoke.ArcLength(Contours[j], true);
					VectorOfPoint positions = new VectorOfPoint();
					CvInvoke.ApproxPolyDP(Contours[j], positions, 0.03 * peramiter, true);
					var moments = CvInvoke.Moments((Contours[j]));
					gShapes.Add(new Shape());
					//Find Centroid of shape and area and store in shape class
					gShapes[j].x_Center = (moments.M10 / moments.M00);
					gShapes[j].y_Center = (moments.M01 / moments.M00);
					gShapes[j].area = CvInvoke.ContourArea(Contours[j]);
				}

				if (gShapes.Count > 0) {
					for (int i = 0; i < gShapes.Count; i++) {
						if (gShapes[i].area > 400 || gShapes[i].area < 20000) {
							gShapes.RemoveAt(i); // remove unwanted shapes
						}
					}
					/*
										// outline grid squares found
										gridDrawn = gridImg.Convert<Bgr, byte>();
										for(int i =0;i<gShapes.Count; i++)
										{
											Rectangle boundingRect = new Rectangle((int)(gShapes[i].x_Center - 50), (int)(gShapes[i].y_Center - 50), 100, 100);
											gridDrawn.Draw(boundingRect, new Bgr(0, 0, 255), 3, LineType.EightConnected, 0);
										}

										for(int i = 0; i < gShapes.Count; i++)
										{
											if (LastPosition.Count == 0)
											{
												LastPosition.Add(gShapes[i]); // store shapes positions for next rotation
												start = 0;
												end = foundShape.Count;
												//check if centroids are close to those of found shapes
												for (int j = 0; j < foundShape.Count; j++)
												{
													// Check centerpoints with tolerance of +- 20 
													if(((foundShape[j].x_Center < gShapes[i].x_Center + 20) && (foundShape[j].x_Center > gShapes[i].x_Center - 20)) && ((foundShape[j].y_Center < gShapes[i].y_Center + 20) && (foundShape[j].y_Center > gShapes[i].y_Center - 20)))
													{
														key[i] = shapeType[j];
													}
												}

											}
											else
											{
												int tEnd = 0;
												for(int j = 0; j < gShapes.Count; j++)
												{

													if (((LastPosition[j].x_Center < gShapes[i].x_Center + 10) && (LastPosition[j].x_Center > gShapes[i].x_Center - 10)) && ((LastPosition[j].y_Center < gShapes[i].y_Center + 10) && (LastPosition[j].y_Center > gShapes[i].y_Center - 10)))
													{
														tEnd = j;
													}
													end = tEnd;
													start = (end - foundShape.Count);

												}

												for (int j = 0; j < gShapes.Count; j++)
												{

													if (((foundShape[j].x_Center < gShapes[i].x_Center + 20) && (foundShape[j].x_Center > gShapes[i].x_Center - 20)) && ((foundShape[j].y_Center < gShapes[i].y_Center + 20) && (foundShape[j].y_Center > gShapes[i].y_Center - 20)))
													{
														key[i + start] = shapeType[j];
													}

												}
											}
										}
						*/
				} // Grid analysis

				// Display Images
				pictureBox0.Image = frame.Bitmap;
				pictureBox1.Image = coralNestDrawn.Bitmap;
				pictureBox2.Image = coralOutcropDrawn.Bitmap;
				pictureBox3.Image = starfishDrawn.Bitmap;
				pictureBox4.Image = drawnImage.Bitmap;
				pictureBox5.Image = laneImg.Bitmap;
				GridBox.Image = gridDrawn.Bitmap;

				if (!Sleep(20)) {
					this.Invoke(new Action(() => { Close(); }));
					break;
				}
			}
        }

        private void Form1_Load(object sender, EventArgs e) {
            popup Popup = new popup(this);
            Popup.Show();

            //Define Preset Values Here
            for (int i = 0; i < 6; i++){
                colorThresholds.Add(new Thresholds());
            }

            // Coral - Pink
            colorThresholds[0].h_Upper = 180;
            colorThresholds[0].h_Lower = 0;
            colorThresholds[0].s_Upper = 255;
            colorThresholds[0].s_Lower = 0;
            colorThresholds[0].v_Upper = 255;
            colorThresholds[0].v_Lower = 0;

            // Coral - Outcrop - Yellow
            colorThresholds[1].h_Upper = 180;
            colorThresholds[1].h_Lower = 0;
            colorThresholds[1].s_Upper = 255;
            colorThresholds[1].s_Lower = 0;
            colorThresholds[1].v_Upper = 255;
            colorThresholds[1].v_Lower = 0;

            // Starfish - Red
            colorThresholds[2].h_Upper = 180;
            colorThresholds[2].h_Lower = 0;
            colorThresholds[2].s_Upper = 255;
            colorThresholds[2].s_Lower = 0;
            colorThresholds[2].v_Upper = 255;
            colorThresholds[2].v_Lower = 0;

            // Spong - Circle
            colorThresholds[4].h_Upper = 180;
            colorThresholds[4].h_Lower = 0;
            colorThresholds[4].s_Upper = 255;
            colorThresholds[4].s_Lower = 0;
            colorThresholds[4].v_Upper = 255;
            colorThresholds[4].v_Lower = 0;


            // Lane - Blue
            colorThresholds[4].h_Upper = 180;
            colorThresholds[4].h_Lower = 0;
            colorThresholds[4].s_Upper = 255;
            colorThresholds[4].s_Lower = 0;
            colorThresholds[4].v_Upper = 255;
            colorThresholds[4].v_Lower = 0;

            // Grid
            colorThresholds[5].h_Upper = 180;
            colorThresholds[5].h_Lower = 0;
            colorThresholds[5].s_Upper = 255;
            colorThresholds[5].s_Lower = 0;
            colorThresholds[5].v_Upper = 255;
            colorThresholds[5].v_Lower = 0;


            //---------Initialize Trackbars 
            //TB 1 == H Upper Threshold 
            trackBar1.Maximum = 180;
            trackBar1.TickFrequency = 5;
            trackBar1.LargeChange = 3;
            trackBar1.SmallChange = 1;
            //TB 2 == H Lower Threshold
            trackBar2.Maximum = 180;
            trackBar2.TickFrequency = 5;
            trackBar2.LargeChange = 3;
            trackBar2.SmallChange = 1;

            //TB 3 == S Upper Threshold 
            trackBar3.Maximum = 255;
            trackBar3.TickFrequency = 5;
            trackBar3.LargeChange = 3;
            trackBar3.SmallChange = 1;
            //TB 4 == S Lower Threshold
            trackBar4.Maximum = 255;
            trackBar4.TickFrequency = 5;
            trackBar4.LargeChange = 3;
            trackBar4.SmallChange = 1;

            //TB 5 == V Upper Threshold 
            trackBar5.Maximum = 255;
            trackBar5.TickFrequency = 5;
            trackBar5.LargeChange = 3;
            trackBar5.SmallChange = 1;
            //TB 6 == V Lower Threshold
            trackBar6.Maximum = 255;
            trackBar6.TickFrequency = 5;
            trackBar6.LargeChange = 3;
            trackBar6.SmallChange = 1;

            seteTrackbars(count);
            label1.BackColor = Color.Red;
        }

        private void backButton_Click(object sender, EventArgs e) {
            if (count == 0){
                count = 5;
            }else{
                --count;
            }

            switch (count){
                case 0:
                    label1.BackColor = Color.Red;
                    label2.BackColor = Color.Empty;
                    break;
                case 1:
                    label2.BackColor = Color.Red;
                    label3.BackColor = Color.Empty;
                    break;
                case 2:
                    label3.BackColor = Color.Red;
                    label4.BackColor = Color.Empty;
                    break;
                case 3:
                    label4.BackColor = Color.Red;
                    label5.BackColor = Color.Empty;
                    break;
                case 4:
                    label5.BackColor = Color.Red;
                    label6.BackColor = Color.Empty;
                    break;
                case 5:
                    label6.BackColor = Color.Red;
                    label1.BackColor = Color.Empty;
                    break;
            }

            seteTrackbars(count);
        }

        private void nextButton_Click(object sender, EventArgs e){
            if (count == 5){
                count = 0;
            }else{
                ++count;
            }

            switch (count){
                case 0:
                    label1.BackColor = Color.Red;
                    label6.BackColor = Color.Empty;
                    break;
                case 1:
                    label2.BackColor = Color.Red;
                    label1.BackColor = Color.Empty;
                    break;
                case 2:
                    label3.BackColor = Color.Red;
                    label2.BackColor = Color.Empty;
                    break;
                case 3:
                    label4.BackColor = Color.Red;
                    label3.BackColor = Color.Empty;
                    break;
                case 4:
                    label5.BackColor = Color.Red;
                    label4.BackColor = Color.Empty;
                    break;
                case 5:
                    label6.BackColor = Color.Red;
                    label5.BackColor = Color.Empty;
                    break;
            }

            seteTrackbars(count);
        }

        private void seteTrackbars(int index){
            trackBar1.Value = (int)(colorThresholds[index].h_Upper);
            textBox1.Text = colorThresholds[index].h_Upper.ToString();

            trackBar2.Value = (int)(colorThresholds[index].h_Lower);
            textBox2.Text = colorThresholds[index].h_Lower.ToString();

            trackBar3.Value = (int)(colorThresholds[index].s_Upper);
            textBox3.Text = colorThresholds[index].s_Upper.ToString();

            trackBar4.Value = (int)(colorThresholds[index].s_Lower);
            textBox4.Text = colorThresholds[index].s_Lower.ToString();

            trackBar5.Value = (int)(colorThresholds[index].v_Upper);
            textBox5.Text = colorThresholds[index].v_Upper.ToString();

            trackBar6.Value = (int)(colorThresholds[index].v_Lower);
            textBox6.Text = colorThresholds[index].v_Lower.ToString();
        }

        private void trackbar_scrolled(object sender, EventArgs e) {
            TextBox textBox = null;
            TrackBar trackBar = null;
            if (sender == trackBar1){
                trackBar = trackBar1;
                colorThresholds[count].h_Upper = trackBar.Value;
                textBox = textBox1;
            }else{
                if (sender == trackBar2){
                    trackBar = trackBar2;
                    colorThresholds[count].h_Lower = trackBar.Value;
                    textBox = textBox2;
                }else{
                    if (sender == trackBar3){
                        trackBar = trackBar3;
                        colorThresholds[count].s_Upper = trackBar.Value;
                        textBox = textBox3;
                    }else{
                        if (sender == trackBar4){
                            trackBar = trackBar4;
                            colorThresholds[count].s_Lower = trackBar.Value;
                            textBox = textBox4;
                        }else{
                            if (sender == trackBar5){
                                trackBar = trackBar5;
                                colorThresholds[count].v_Upper = trackBar.Value;
                                textBox = textBox5;
                            }else{
                                trackBar = trackBar6;
                                colorThresholds[count].v_Lower = trackBar.Value;
                                textBox = textBox6;
                            }
                        }
                    }
                }
            }

            textBox.Text = trackBar.Value.ToString();
        }

        private void textBox_Changed(object sender, EventArgs e){
            TextBox textBox = null;
            TrackBar trackBar = null;
            int stringToText;

            if (sender == textBox1){
                trackBar = trackBar1;
                textBox = textBox1;
                if (Int32.TryParse(textBox.Text, out stringToText)){
                    colorThresholds[count].h_Upper = stringToText;
                    if(stringToText < 181 && stringToText >= 0){
                        trackBar.Value = stringToText;
                    }
                }
            }else{
                if (sender == textBox2){
                    trackBar = trackBar2;
                    textBox = textBox2;
                    if (Int32.TryParse(textBox.Text, out stringToText)){
                        colorThresholds[count].h_Lower = stringToText;
                        if (stringToText < 181 && stringToText >= 0){
                            trackBar.Value = stringToText;
                        }
                    }
                }else{
                    if (sender == textBox3){
                        trackBar = trackBar3;
                        textBox = textBox3;
                        if (Int32.TryParse(textBox.Text, out stringToText)){
                            colorThresholds[count].s_Upper = stringToText;
                            if (stringToText <= 255 && stringToText >= 0){
                                trackBar.Value = stringToText;
                            }
                        }
                    }else{
                        if (sender == textBox4){
                            trackBar = trackBar4;
                            textBox = textBox4;
                            if (Int32.TryParse(textBox.Text, out stringToText)){
                                colorThresholds[count].s_Lower = stringToText;
                                if (stringToText <= 255 && stringToText >= 0){
                                    trackBar.Value = stringToText;
                                }
                            }
                        }else{
                            if (sender == textBox5){
                                trackBar = trackBar5;
                                textBox = textBox5;
                                if (Int32.TryParse(textBox.Text, out stringToText)){
                                    colorThresholds[count].v_Upper = stringToText;
                                    if (stringToText <= 255 && stringToText >= 0){
                                        trackBar.Value = stringToText;
                                    }
                                }
                            }else{
                                trackBar = trackBar6;
                                textBox = textBox6;
                                if (Int32.TryParse(textBox.Text, out stringToText)){
                                    colorThresholds[count].v_Lower = stringToText;
                                    if (stringToText <= 255 && stringToText >= 0){
                                        trackBar.Value = stringToText;
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Close threads on form closing
            //_captureThread.Abort();
        }
    }
}
