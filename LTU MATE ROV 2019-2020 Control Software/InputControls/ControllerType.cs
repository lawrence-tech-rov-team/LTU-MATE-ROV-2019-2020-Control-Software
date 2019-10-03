using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.InputControls {
	public enum ControllerType {
		None,
		Joystick,
		Keyboard
	}

	public static class ControllerTypeHelperClass {

		public static IController GetNewController(this ControllerType type) {
			switch (type) {
				case ControllerType.None: return null;
				case ControllerType.Joystick: return new JoystickController();
				case ControllerType.Keyboard: return new KeyboardController();
				default: return null;
			}
		}

	}
}
