using JoystickInput;
using LTU_MATE_ROV_2019_2020_Control_Software.InputControls.Joysticks;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.InputControls {
	public abstract class InputDevice {

		public Twist Value { get; set; }
		public abstract string Name { get; }

		public abstract void Connect();
		public abstract void Disconnect();
		public abstract bool Update();

		public override string ToString() {
			return Name;
		}

		public static InputDevice[] GetAvailableDevices() {
			List<InputDevice> devices = new List<InputDevice>();

			devices.AddRange(Joysticks.JoystickInput.GetDevices());
			devices.AddRange(ControllerInput.GetDevices());

			return devices.ToArray();
		}

	}
}
