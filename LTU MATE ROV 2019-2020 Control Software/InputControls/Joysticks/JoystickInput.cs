using JoystickInput;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.InputControls.Joysticks {
	public class JoystickInput : InputDevice {

		private Joystick joystick;
		private JoystickDevice device;
		private JoystickConfig config;
		private Dictionary<JoystickControl, int> states = new Dictionary<JoystickControl, int>();
		public override string Name => device?.Name ?? "null (Joystick)";

		private JoystickInput(JoystickDevice device) {
			this.device = device;
			config = JoystickConfig.GetConfig(device.Name);
			states[JoystickControl.PointOfViewControllers0] = -1;
		}

		private void Joystick_OnInputChanged(Joystick sender, JoystickControl Type, int Value) {
			states[Type] = Value;
		}

		public override void Connect() {
			Disconnect();
			joystick = Joystick.Connect(device);
			if(joystick != null) joystick.OnInputChanged += Joystick_OnInputChanged;
		}

		public override void Disconnect() {
			if(joystick != null) {
				joystick.OnInputChanged -= Joystick_OnInputChanged;
				joystick.Disconnect();
			}
			joystick = null;
			foreach(JoystickControl control in EnumUtil.GetValues<JoystickControl>()) {
				states[control] = default(int);
			}
		}

		public override bool Update() {
			if (!(joystick?.Update() ?? false)) {
				Disconnect();
				return false;
			} else {
				Value = config.Translate(states);
				return true;
			}
		}

		public static InputDevice[] GetDevices() {
			return Joystick.GetAvailableJoysticks().Select(x => new JoystickInput(x)).ToArray();
		}

	}

}
