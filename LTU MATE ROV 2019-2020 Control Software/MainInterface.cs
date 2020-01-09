using JoystickInput;
using LTU_MATE_ROV_2019_2020_Control_Software.InputControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
	}
}
