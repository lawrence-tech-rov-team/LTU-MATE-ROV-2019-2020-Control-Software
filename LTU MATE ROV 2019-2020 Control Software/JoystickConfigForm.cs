using JoystickInput;
using Meters;
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
	public partial class JoystickConfigForm : Form {

		private Joystick joystick;
		private IOMeter[] buttons;

		public JoystickConfigForm() {
			InitializeComponent();
			buttons = new IOMeter[] { Btn0, Btn1, Btn2, Btn3, Btn4, Btn5, Btn6, Btn7, Btn8, Btn9, Btn10, Btn11 };
		}

		private void JoystickConfigForm_Load(object sender, EventArgs e) {
			InputTimer.Enabled = true;
		}

		private void JoystickConfigForm_FormClosing(object sender, FormClosingEventArgs e) {
			DisconnectJoystick();
			InputTimer.Enabled = false;
		}

		private bool ConnectJoystick(JoystickDevice device) {
			if (joystick != null) DisconnectJoystick();
			joystick = Joystick.Connect(device);
			if(joystick == null) {
				Console.WriteLine("Could not connect to \'" + device + "\'");
				return false;
			} else {
				Console.WriteLine("Connected to \'" + device + "\'");
				joystick.OnInputChanged += OnJoystickUpdate;
				return true;
			}
		}

		private void DisconnectJoystick() {
			if (joystick == null) return;
			joystick.Disconnect();
			Console.WriteLine("Disconnected \'" + joystick + "\'");
			joystick.OnInputChanged -= OnJoystickUpdate;
			joystick = null;
		}

		private void OnJoystickUpdate(Joystick sender, SharpDX.DirectInput.JoystickOffset type, int value) {
			//Console.WriteLine(type.ToString() + " = " + value);
			if (type == SharpDX.DirectInput.JoystickOffset.Sliders0) {
				PowerMeter.Value = (UInt16)value;
			} else if (type == SharpDX.DirectInput.JoystickOffset.Y) {
				AxisPointer.YValue = PitchMeter.Value = (UInt16)value;
			} else if (type == SharpDX.DirectInput.JoystickOffset.X) {
				AxisPointer.XValue = RollMeter.Value = (UInt16)value;
			} else if (type == SharpDX.DirectInput.JoystickOffset.RotationZ) {
				YawMeter.Value = (UInt16)value;
			} else if ((type >= SharpDX.DirectInput.JoystickOffset.Buttons0) && (type <= SharpDX.DirectInput.JoystickOffset.Buttons11)) {
				int index = type - SharpDX.DirectInput.JoystickOffset.Buttons0;
				buttons[index].Value = (value > 0);
			} else if (type == SharpDX.DirectInput.JoystickOffset.PointOfViewControllers0) {
				if (value == -1) HatMeter.Value = POVDirection.Center;
				else {
					int angle = value / 4500;
					HatMeter.Value = (POVDirection)(1 << angle);
				}
			} else {
				Console.WriteLine(type.ToString() + " = " + value);
			}
		}

		private void InputTimer_Tick(object sender, EventArgs e) {
			if (joystick != null) joystick.Update();
		}

		private void PollingRateInput_ValueChanged(object sender, EventArgs e) {
			InputTimer.Interval = decimal.ToInt32(PollingRateInput.Value);
		}

		private void DeviceSelector_DropDown(object sender, EventArgs e) {
			List<JoystickDevice> joysticks = Joystick.GetAvailableJoysticks();
			DeviceSelector.Items.Clear();
			DeviceSelector.Items.AddRange(joysticks.ToArray());
		}

		private void DeviceSelector_SelectedIndexChanged(object sender, EventArgs e) {
			DisconnectJoystick();
			object selectedItem = DeviceSelector.SelectedItem;
			if((selectedItem != null) && (selectedItem is JoystickDevice)) {
				ConnectJoystick((JoystickDevice)selectedItem);
			}
		}

	}
}
