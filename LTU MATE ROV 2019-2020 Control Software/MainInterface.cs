﻿using ExcelInterface.Writer;
using JoystickInput;
using LTU_MATE_ROV_2019_2020_Control_Software.Cameras;
using LTU_MATE_ROV_2019_2020_Control_Software.Hardware;
using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.Actuators;
using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.DataTypes;
using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.Ethernet;
using LTU_MATE_ROV_2019_2020_Control_Software.InputControls;
using LTU_MATE_ROV_2019_2020_Control_Software.InputControls.Joysticks;
using LTU_MATE_ROV_2019_2020_Control_Software.InputControls.Keyboard;
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

		private const ThreadPriority RovThreadPriority = ThreadPriority.Normal;

		private Random rnd = new Random();
		private LogWindow LogWindow = new LogWindow();

		private ROV rov;
		private InputThread inputThread;
		private CameraThread cameras;

		public MainInterface() {
			InitializeComponent();
			inputThread = new InputThread(ThreadPriority.Normal);
			cameras = new CameraThread(ThreadPriority.Normal);
		}

		private void MainInterface_Load(object sender, EventArgs e) {
			//RobotThread.Start();
			//RobotThread.SetControllerType(currentController, this);
			this.GetLogger().AddOutput(LogWindow);
			rov = new ROV(RovThreadPriority, new EthernetInterface()); //TODO make this null by default, let Connect() create it. Need null handling tho
																	   //foreach (char c in rov.Servos.Keys) LetterBox.Items.Add(c);

			cameras.Start();
			InputDataTimer.Start();
		}

		private void MainInterface_FormClosing(object sender, FormClosingEventArgs e) {
			rov.StopAsync(); //TODO before disconnecting, release all servos
			cameras.StopAsync();
			inputThread.StopAsync();

			rov.Stop();
			cameras.Stop();
			inputThread.Stop();
		}

		private void ControlsMenu_Click(object sender, EventArgs e) {
			
		}

		private void InputDataTimer_Tick(object sender, EventArgs e) {
			lock (this) {
				TestBtnMeter.Value = rov.Button0.State;
				TestBtn2.Value = rov.Button1.State;

				TempLabel.Text = "Temperature: " + rov.IMU.Temperature.ToString().PadLeft(4) + "°C";
				//Vector3Data euler = rov.IMU.Euler;
				Vector3Data accel = rov.IMU.Accelerometer;

				/*if (euler != null) {
					EulerX.Text = "X: " + euler.x.ToString("0.00").PadLeft(10) + "°";
					EulerY.Text = "Y: " + euler.y.ToString("0.00").PadLeft(10) + "°";
					EulerZ.Text = "Z: " + euler.z.ToString("0.00").PadLeft(10) + "°";
				}*/

				if (accel != null) {
					AccelX.Text = "X: " + accel.x.ToString("0.00").PadLeft(10) + " m/s²";
					AccelY.Text = "Y: " + accel.y.ToString("0.00").PadLeft(10) + "m/s²";
					AccelZ.Text = "Z: " + accel.z.ToString("0.00").PadLeft(10) + "m/s²";
				}

				WaterTempLabel.Text = "Water Temp: " + rov.PressureSensor.Temperature.ToString("0.00").PadLeft(10) + "°C";
				PressureLabel.Text = "Pressure: " + rov.PressureSensor.Pressure.ToString("0.00").PadLeft(10) + " mBar";
				AltitudeLabel.Text = "Altitude: " + rov.PressureSensor.Altitude.ToString("0.00").PadLeft(10) + " m above mean sea";
				DepthLabel.Text = "Depth: " + rov.PressureSensor.Depth.ToString("0.00").PadLeft(10) + " m";

				//PowerMeter.Value = Math.Min(PowerMeter.Maximum, Math.Max(PowerMeter.Minimum,
				//	(decimal)inputThread.Input.Linear.X * (PowerMeter.Maximum - PowerMeter.Minimum) + PowerMeter.Minimum
				//));
				//InputControlData data = RobotThread.GetInputData();
				//if (data == null) data = new InputControlData(); 
				//PowerMeter.Value = Math.Max(-1, Math.Min(1, (decimal)data.ForwardThrust));
				CameraView1.Image = cameras.Image;
			}
			
		}

		private void SaveExcelToolStripMenuItem_Click(object sender, EventArgs e) {
			try {
				using(ExcelFileWriter file = ExcelFileWriter.OpenExcelApplication()) {
					if (file == null) throw new NullReferenceException("Failed to open the Excel application.");
					using (WorkbookWriter book = file.CreateNewWorkbook()) {
						if (book == null) throw new NullReferenceException("Failed to create a new Excel workbook.");
						WorksheetWriter sheet = book.GetActiveWorksheet();
						if (sheet == null) throw new NullReferenceException("Failed to find the active worksheet.");
						sheet.Name = "TestSheet1";

						int col;
						int row = WorksheetWriter.MinRow;
						for(; row <= 2; row++) { //2 rows
							for(col = WorksheetWriter.MinColumn; col <= 5; col++) { //5 cols
								sheet[row, col] = "R" + row + "C" + col;
								if (row == WorksheetWriter.MinRow) sheet.Bold(row, col);
							}
						}

						row += 2;
						col = WorksheetWriter.MinColumn;
						sheet[row, col] = "This is an extra long cell to fit.";

						sheet.AutoFitAllColumns();


						WorksheetWriter sheet2 = book.CreateNewWorksheet();
						sheet2.Name = "TestSheet2";
						sheet[WorksheetWriter.MinRow, WorksheetWriter.MinColumn] = "This is really long but isn't fitted.";

						book.Save("TestExcel" + WorkbookWriter.DEFAULT_FILE_EXTENSION);
					}
				}
			}catch(Exception) {
				MessageBox.Show("Error");
			}
		}

		private void SaveCSVToolStripMenuItem_Click(object sender, EventArgs e) {
			List<string> lines = new List<string>();
			List<string> line = new List<string>();

			for(int row = 0; row < 2; row++) { //two rows
				line.Clear();
				for (int col = 0; col < 5; col++) { //5 cols
					line.Add("R" + row + "C" + col);
				}

				lines.Add(string.Join(",", line.Select(cell => "\"" + cell + "\"").ToArray()));
			}

			try {
				string path = "TestCsv.csv";
				if (File.Exists(path)) File.Delete(path);
				File.WriteAllLines(path, lines);
				return; //Return true
			} catch (Exception) {
				MessageBox.Show("Error");
			}
		}

		private void ConnectToolStripMenuItem_Click(object sender, EventArgs e) {
			if((rov == null) || (rov.IsSimulator)) {
				rov?.Disconnect();
				rov = new ROV(RovThreadPriority, new EthernetInterface());
			}

			if (rov.Connect()) {
				MessageBox.Show("Connected!");
			} else {
				MessageBox.Show("Could not connect to device.");
			}
		}

		private void DisconnectToolStripMenuItem_Click(object sender, EventArgs e) {
			rov.Disconnect();
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
			long? timeMs = rov.Ping(1000);
			if(timeMs == null) {
				MessageBox.Show("Ping failed.");
			} else {
				MessageBox.Show("Ping: " + (long)timeMs + " ms");
			}
		}

		private void SimulatorToolStripMenuItem_Click(object sender, EventArgs e) {
			lock (this) {
				rov?.Disconnect();

				RobotSimulator sim = new RobotSimulator();
				rov = new ROV(RovThreadPriority, sim);
				rov.Connect();
			}
		}

		private void LedBtn_MouseDown(object sender, MouseEventArgs e) {
			rov.Led.Enabled = true;
		}

		private void LedBtn_MouseUp(object sender, MouseEventArgs e) {
			rov.Led.Enabled = false;
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
			InputComboBox.Items.AddRange(InputProgram.GetAvailablePrograms());
		}

		private void InputToolStripMenuItem_Click(object sender, EventArgs e) {
			InputVisualizer visualizer = new InputVisualizer(inputThread);
			KeyboardProgram.KeyListener = visualizer;
			visualizer.Show();
		}

		private void SensorsToolStripMenuItem_Click(object sender, EventArgs e) {
			new SensorsForm(rov).Show();
		}
	}
}
