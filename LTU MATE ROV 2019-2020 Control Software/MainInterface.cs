using CustomLogger;
using CustomLogger.Outputs;
using ExcelInterface.Writer;
using JoystickInput;
using JsonSerializable;
using LTU_MATE_ROV_2019_2020_Control_Software.Cameras;
using LTU_MATE_ROV_2019_2020_Control_Software.Controls;
using LTU_MATE_ROV_2019_2020_Control_Software.InputControls;
using LTU_MATE_ROV_2019_2020_Control_Software.InputControls.Joysticks;
using LTU_MATE_ROV_2019_2020_Control_Software.InputControls.Keyboard;
using LTU_MATE_ROV_2019_2020_Control_Software.Robot;
using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.DataTypes;
using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.Ethernet;
using LTU_MATE_ROV_2019_2020_Control_Software.Settings;
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
	public partial class MainInterface : Form {

		//Threads
		private RobotThread robotThread;
		private InputThread inputThread;
		private CameraThread cameraThread;
		private ControlsThread controlsThread;

		//Simulator window
		private RobotSimulatorUI simulator;

		//Misc
		private LogWindow LogWindow = new LogWindow();
		private SettingsForm settingsForm;
		private AppSettings settings;

		private bool InitializeLogging() {
			Log.StartLogger(ThreadPriority.BelowNormal);
			Log.AddOutput(new ConsoleLogger(), LogLevel.Info);
			Log.Info("Program started.");
			FileLogger fileLog = FileServices.GetLogFile();
			if (fileLog == null) {
				Log.Fatal("Unable to save the log to a file!");
				Application.Exit();
				return false;
			}
			Log.AddOutput(fileLog, LogLevel.Debug);
			Log.Info("File log opened.");
			FileServices.DeleteOldLogs();

			Log.AddOutput(LogWindow);
			Log.Info("Log window initialized.");
			return true;
		}

		//Initialize window, create threads / thread switchers, and initialize logger.
		public MainInterface() {
			try {
				Thread.CurrentThread.Name = "Main UI";
			} catch (Exception) { }

			if (!InitializeLogging()) return;
			Log.Info("Logging initialized.");

			InitializeComponent();
			Log.Info("Program initialized.");

			inputThread = new InputThread(ThreadPriority.Normal);
			cameraThread = new CameraThread(ThreadPriority.Normal);
			robotThread = new RobotThread(ThreadPriority.Normal);
			controlsThread = new ControlsThread(inputThread, robotThread, ThreadPriority.Normal);
			Log.Info("Threads initialized.");

			settings = new AppSettings(robotThread);
		}

		//Once window loads, initialize logging window, load settings, and start threads
		private void MainInterface_Load(object sender, EventArgs e) {
			if(!settings.Load()) {
				MessageBox.Show("An error occured while loading the settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			Log.Info("Main window loaded.");
			cameraThread.Start();
			controlsThread.Start();
			Log.Info("Threads started.");

			InputDataTimer.Start();
			ImageUpdateTimer.Start();
			Log.Info("Update timers started.");

			robotThread.OnIdCollisionDetected += RobotThread_OnIdCollisionDetected;
		}

		//Stop all running threads and switchers
		private void MainInterface_FormClosing(object sender, FormClosingEventArgs e) {
			InputDataTimer.Stop();
			ImageUpdateTimer.Stop();
			Log.Info("Update timers stopped.");
			//TODO before disconnecting, release all servos
			robotThread.StopAsync();
			cameraThread.StopAsync();
			inputThread.StopAsync();
			controlsThread.StopAsync();

			robotThread.Stop();
			cameraThread.Stop();
			inputThread.Stop();
			controlsThread.Stop();
			Log.Info("All threads stopped.");

			Log.Stop();
		}

		private void InputDataTimer_Tick(object sender, EventArgs e) {
			ROV rov = robotThread.Robot;
		}

		private void LogToolStripMenuItem_Click(object sender, EventArgs e) {
			LogWindow.Open();
			Log.Info("Log window opened.");
		}

		private void HardwarePingToolStripMenuItem_Click(object sender, EventArgs e) {
			ROV robot = robotThread.Robot;
			if(robot == null) {
				MessageBox.Show("No robot connected!");
			} else {
				Log.Info("Pinging...");
				long? timeMs = robot.Ping(1000);
				if(timeMs == null) {
					Log.Info("Ping failed.");
					MessageBox.Show("Ping failed.");
				} else {
					Log.Info("Ping responded in " + ((long)timeMs).ToString() + " ms.");
					MessageBox.Show("Ping: " + (long)timeMs + " ms");
				}
			}
			
		}

		private void SimulatorToolStripMenuItem_Click(object sender, EventArgs e) {
			if(simulator != null) {
				if (simulator.IsDisposed) simulator = null;
			}

			if (simulator == null) {
				Log.Info("Opening simulator...");
				simulator = new RobotSimulatorUI(robotThread);
				simulator.Show();
			}
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
			Log.Info("Connecting to robot...");
			robotThread.Robot = new ROV(new EthernetInterface());
		}

		private void DisconnectRobot_MenuClick(object sender, EventArgs e) {
			Log.Info("Disconnecting from robot...");
			robotThread.Robot = null;
		}

		private void RobotThread_OnIdCollisionDetected(byte IdConflict) {
			this.Invoke(new Action(() => {
				MessageBox.Show("Id collision detected: " + IdConflict, "Id Conflict", MessageBoxButtons.OK);
			}));
		}

		private void settingsToolStripMenuItem_Click(object sender, EventArgs e) {
			if (settingsForm != null) {
				if (settingsForm.IsDisposed) settingsForm = null;
			}

			if (settingsForm == null) {
				Log.Info("Opening settings...");
				settingsForm = new SettingsForm(robotThread, controlsThread, settings);
				settingsForm.Show();
			}
		}

		private void GrippersComboBox_DropDown(object sender, EventArgs e) {
			GrippersComboBox.Items.Clear();
			GrippersComboBox.Items.AddRange(new GripperPosition[]{
				settings.SpongeGripper,
				settings.MediumGripper,
				settings.SmallGripper,
				settings.TinyGripper,
				settings.NetGripper
			});
		}

		private void GrippersComboBox_SelectedIndexChanged(object sender, EventArgs e) {
			GripperPosition gripper = null;
			object obj = GrippersComboBox.SelectedItem;
			if((obj != null) && (obj is GripperPosition)) {
				gripper = (GripperPosition)obj;
			}
			controlsThread.Gripper = gripper;
		}
	}
}
