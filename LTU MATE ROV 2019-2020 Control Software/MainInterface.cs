using ExcelInterface.Writer;
using JoystickInput;
using LTU_MATE_ROV_2019_2020_Control_Software.InputControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTU_MATE_ROV_2019_2020_Control_Software {
	public partial class MainInterface : Form, IKeyboardListener {

		private ControllerType currentController = ControllerType.None;

		public MainInterface() {
			InitializeComponent();
		}

		private void MainInterface_Load(object sender, EventArgs e) {
			RobotThread.Start();
			RobotThread.SetControllerType(currentController, this);
			this.KeyPreview = true;

			InputDataTimer.Start();
		}

		private void MainInterface_FormClosing(object sender, FormClosingEventArgs e) {
			RobotThread.RequestStop();
			//Stop other threads
			RobotThread.Stop();
		}

		private void ControlsMenu_Click(object sender, EventArgs e) {
			
		}

		private void KeyboardMenu_Click(object sender, EventArgs e) {
			new KeyboardConfigForm().ShowDialog();
			RobotThread.SetControllerType(currentController, this);
		}

		private void JoystickMenu_Click(object sender, EventArgs e) {
			new JoystickConfigForm().ShowDialog();
			RobotThread.SetControllerType(currentController, this);
		}

		private void InputDataTimer_Tick(object sender, EventArgs e) {
			InputControlData data = RobotThread.GetInputData();
			if (data == null) data = new InputControlData(); 
			PowerMeter.Value = Math.Max(-1, Math.Min(1, (decimal)data.ForwardThrust));
		}

		private void ControllerTypeButton_CheckedChanged(object sender, EventArgs e) {
			if (!(sender is RadioButton)) return;
			if (((RadioButton)sender).Checked) {
				currentController = ControllerType.None;
				if (sender == KeyboardBtn) currentController = ControllerType.Keyboard;
				else if (sender == JoystickBtn) currentController = ControllerType.Joystick;

				RobotThread.SetControllerType(currentController, this);
			}
		}

		private void saveExcelToolStripMenuItem_Click(object sender, EventArgs e) {
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

		private void saveCSVToolStripMenuItem_Click(object sender, EventArgs e) {
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
	}
}
