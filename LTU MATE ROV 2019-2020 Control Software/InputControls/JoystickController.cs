using JoystickInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.InputControls { 
	public class JoystickController : IController{

		private float fPower;
		public float ForwardPower {
			get => fPower;
			private set => fPower = Math.Max(-1f, Math.Min(1f, value));
		}

		private float sPower;
		public float SidePower {
			get => sPower;
			private set => sPower = Math.Max(-1f, Math.Min(1f, value));
		}

		private Joystick joystick;

		public bool Connect() {
			DisconnectJoystick();

			List<JoystickDevice> devices = Joystick.GetAvailableJoysticks();
			foreach(JoystickDevice device in devices) {
				if (ConnectJoystick(device)) return true;
			}

			return false;
		}

		private bool ConnectJoystick(JoystickDevice device) {
			if (joystick != null) DisconnectJoystick();
			joystick = Joystick.Connect(device);
			if (joystick == null) {
				Console.WriteLine("Could not connect to \'" + device + "\'");
				return false;
			} else {
				Console.WriteLine("Connected to \'" + device + "\'");
				joystick.OnInputChanged += OnJoystickUpdate;
				return true;
			}
		}

		public void Disconnect() {
			DisconnectJoystick();
		}

		private void DisconnectJoystick() {
			if (joystick == null) return;
			joystick.Disconnect();
			Console.WriteLine("Disconnected \'" + joystick + "\'");
			joystick.OnInputChanged -= OnJoystickUpdate;
			joystick = null;
		}

		public void Update() {
			if (joystick != null) joystick.Update();
		}

		private void OnJoystickUpdate(Joystick sender, JoystickControl type, int value) {
			//Console.WriteLine(type.ToString() + " = " + value);
			if (type == JoystickControl.Sliders0) {
				//Little power/thrust thingy
			} else if (type == JoystickControl.Y) {
				ForwardPower = (1f - value / 65535f) * 2f - 1f;
			} else if (type == JoystickControl.X) {
				SidePower = value / 65535f * 2f - 1f;
			} else if (type == JoystickControl.RotationZ) {
				//The twisty bit
			} else if ((type >= JoystickControl.Buttons0) && (type <= JoystickControl.Buttons11)) {
				//int index = type - SharpDX.DirectInput.JoystickOffset.Buttons0;
				//buttons[index].Value = (value > 0);
			} else if (type == JoystickControl.PointOfViewControllers0) {
				//if (value == -1) HatMeter.Value = POVDirection.Center;
				//else {
				//	int angle = value / 4500;
				//	HatMeter.Value = (POVDirection)(1 << angle);
				//}
			} else {
				//Console.WriteLine(type.ToString() + " = " + value);
			}
		}
	}
}
