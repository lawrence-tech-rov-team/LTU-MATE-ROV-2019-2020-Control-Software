using JoystickInput;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.InputControls.Joysticks {
	public class JoystickProgram : InputProgram {

		private Joystick joystick;
		private JoystickDevice device;
		private JoystickConfig config;
		private Dictionary<JoystickControl, int> states = new Dictionary<JoystickControl, int>();
		public override string Name => device?.Name ?? "null (Joystick)";

		private JoystickProgram(JoystickDevice device) {
			this.device = device;
			config = JoystickConfig.GetConfig(device.Name);
		}

		private void Joystick_OnInputChanged(Joystick sender, JoystickControl Type, int Value) {
			states[Type] = Value;
		}

		protected override void Initialize() {
			Cleanup();
			joystick = Joystick.Connect(device);
			states[JoystickControl.PointOfViewControllers0] = -1;
			if (joystick != null) joystick.OnInputChanged += Joystick_OnInputChanged;
		}

		protected override bool Loop() {
			if (!(joystick?.Update() ?? false)) {
				return false;
			} else {
				Input = config.Translate(states);
				return Sleep(33);
			}
		}

		protected override void Cleanup() {
			if (joystick != null) {
				joystick.OnInputChanged -= Joystick_OnInputChanged;
				joystick.Disconnect();
			}
			joystick = null;
			foreach (JoystickControl control in EnumUtil.GetValues<JoystickControl>()) {
				states[control] = default(int);
			}
			Input = new Twist();
		}

		public static InputProgram[] GetPrograms() {
			return Joystick.GetAvailableJoysticks().Select(x => new JoystickProgram(x)).ToArray();
		}

	}

}
