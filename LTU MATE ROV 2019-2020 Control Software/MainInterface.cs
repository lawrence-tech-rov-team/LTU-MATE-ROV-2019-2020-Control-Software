using ExcelInterface.Writer;
using JoystickInput;
using LTU_MATE_ROV_2019_2020_Control_Software.Cameras;
using LTU_MATE_ROV_2019_2020_Control_Software.Controls;
using LTU_MATE_ROV_2019_2020_Control_Software.InputControls;
using LTU_MATE_ROV_2019_2020_Control_Software.InputControls.Joysticks;
using LTU_MATE_ROV_2019_2020_Control_Software.InputControls.Keyboard;
using LTU_MATE_ROV_2019_2020_Control_Software.Robot;
using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.DataTypes;
using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.Ethernet;
using LTU_MATE_ROV_2019_2020_Control_Software.Simulator;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTU_MATE_ROV_2019_2020_Control_Software {
	public partial class MainInterface : Form, ILogging {

		private LogWindow LogWindow = new LogWindow(); //TODO static logging class.

		//Threads
		private RobotThread robotThread;
		private InputThread inputThread;
		private CameraThread cameraThread;
		private ControlsThread controlsThread;

		//Simulator window
		private RobotSimulatorUI simulator;

		//Initialize window and create threads / thread switchers
		public MainInterface() {
			InitializeComponent();

			inputThread = new InputThread(ThreadPriority.Normal);
			cameraThread = new CameraThread(ThreadPriority.Normal);
			robotThread = new RobotThread(ThreadPriority.Normal);
			controlsThread = new ControlsThread(inputThread, robotThread, ThreadPriority.Normal);
		}

		//Once window loads, initialize logging window and start threads
		private void MainInterface_Load(object sender, EventArgs e) {
			this.GetLogger().AddOutput(LogWindow);

			cameraThread.Start();
			controlsThread.Start();

			InputDataTimer.Start();
			ImageUpdateTimer.Start();
		}

		//Stop all running threads and switchers
		private void MainInterface_FormClosing(object sender, FormClosingEventArgs e) {
			InputDataTimer.Stop();
			ImageUpdateTimer.Stop();
			//TODO before disconnecting, release all servos
			robotThread.StopAsync();
			cameraThread.StopAsync();
			inputThread.StopAsync();
			controlsThread.StopAsync();

			robotThread.Stop();
			cameraThread.Stop();
			inputThread.Stop();
			controlsThread.Stop();
		}

		private void InputDataTimer_Tick(object sender, EventArgs e) {
			//lock (this) {
			ROV rov = robotThread.Robot;

			TestBtnMeter.Value = rov?.Button0?.State ?? false;
			TestBtn2.Value = rov?.Button1?.State ?? false;

			TempLabel.Text = "Temperature: " + ((rov == null) ? "----" : rov.IMU.Temperature.ToString().PadLeft(4)) + "°C";
			//Vector3Data euler = rov.IMU.Euler;
			Vector3Data accel = rov?.IMU?.Accelerometer ?? new Vector3Data();

			/*if (euler != null) {
				EulerX.Text = "X: " + euler.x.ToString("0.00").PadLeft(10) + "°";
				EulerY.Text = "Y: " + euler.y.ToString("0.00").PadLeft(10) + "°";
				EulerZ.Text = "Z: " + euler.z.ToString("0.00").PadLeft(10) + "°";
			}*/

			//if (accel != null) {
				AccelX.Text = "X: " + accel.x.ToString("0.00").PadLeft(10) + " m/s²";
				AccelY.Text = "Y: " + accel.y.ToString("0.00").PadLeft(10) + "m/s²";
				AccelZ.Text = "Z: " + accel.z.ToString("0.00").PadLeft(10) + "m/s²";
			//}

			WaterTempLabel.Text = "Water Temp: " + ((rov == null) ? "----------" : rov.PressureSensor.Temperature.ToString("0.00").PadLeft(10)) + "°C";
			PressureLabel.Text = "Pressure: " + ((rov == null) ? "----------" : rov.PressureSensor.Pressure.ToString("0.00").PadLeft(10)) + " mBar";
			AltitudeLabel.Text = "Altitude: " + ((rov == null) ? "----------" : rov.PressureSensor.Altitude.ToString("0.00").PadLeft(10)) + " m above mean sea";
			DepthLabel.Text = "Depth: " + ((rov == null) ? "----------" : rov.PressureSensor.Depth.ToString("0.00").PadLeft(10)) + " m";

			//PowerMeter.Value = Math.Min(PowerMeter.Maximum, Math.Max(PowerMeter.Minimum,
			//	(decimal)inputThread.Input.Linear.X * (PowerMeter.Maximum - PowerMeter.Minimum) + PowerMeter.Minimum
			//));
			//InputControlData data = RobotThread.GetInputData();
			//if (data == null) data = new InputControlData(); 
			//PowerMeter.Value = Math.Max(-1, Math.Min(1, (decimal)data.ForwardThrust));
				
			//}
			
		}

		private void LogToolStripMenuItem_Click(object sender, EventArgs e) {
			LogWindow.Show();
		}

		private void Button1_Click(object sender, EventArgs e) {
			this.Log(CustomLogger.LogLevel.Warn, "I\'m warning you!");
		}

		private void Button2_Click(object sender, EventArgs e) {
			this.Log(CustomLogger.LogLevel.Info, "I am not the info desk.");
		}

		private void Button3_Click(object sender, EventArgs e) {
			this.Log(CustomLogger.LogLevel.Debug, "Bugs everywhere!");
		}

		private void HardwarePingToolStripMenuItem_Click(object sender, EventArgs e) {
			ROV robot = robotThread.Robot;
			if(robot == null) {
				MessageBox.Show("No robot connected!");
			} else {
				long? timeMs = robot.Ping(1000);
				if(timeMs == null) {
					MessageBox.Show("Ping failed.");
				} else {
					MessageBox.Show("Ping: " + (long)timeMs + " ms");
				}
			}
			
		}

		private void SimulatorToolStripMenuItem_Click(object sender, EventArgs e) {
			if(simulator != null) {
				if (simulator.IsDisposed) simulator = null;
			}

			if (simulator == null) {
				new RobotSimulatorUI(robotThread).Show();
			}
			//}
		}

		private void LedBtn_MouseDown(object sender, MouseEventArgs e) {
			ROV rov = robotThread.Robot;
			if (rov != null) rov.Led.Enabled = true;
		}

		private void LedBtn_MouseUp(object sender, MouseEventArgs e) {
			ROV rov = robotThread.Robot;
			if (rov != null) rov.Led.Enabled = false;
		}

		private void InputComboBox_SelectedIndexChanged(object sender, EventArgs e) {
			object obj = InputComboBox.SelectedItem;
			if ((obj != null) && (obj is InputProgram)) {
				inputThread.InputDevice = (InputProgram)obj;
			} else {
				inputThread.InputDevice = null;
			}
		}

		private void InputComboBox_DropDown(object sender, EventArgs e) {
			InputComboBox.Items.Clear();
			InputComboBox.Items.AddRange(InputProgram.GetAvailablePrograms(cameraThread));
		}

		private void InputToolStripMenuItem_Click(object sender, EventArgs e) {
			InputVisualizer visualizer = new InputVisualizer(inputThread);
			KeyboardProgram.KeyListener = visualizer;
			visualizer.Show();
		}

		private void SensorsToolStripMenuItem_Click(object sender, EventArgs e) {
			new SensorsForm(robotThread).Show();
		}

		private void MainInterface_Paint(object sender, PaintEventArgs e) {
			
		}

		private void ImageUpdateTimer_Tick(object sender, EventArgs e) {
			CameraView1.Image = cameraThread.Image1;
			CameraView2.Image = cameraThread.Image2;
		}


		private void ConnectRobot_MenuClick(object sender, EventArgs e) {
			robotThread.Robot = new ROV(new EthernetInterface());
		}

		private void DisconnectRobot_MenuClick(object sender, EventArgs e) {
			robotThread.Robot = null;
		}
	}
}
