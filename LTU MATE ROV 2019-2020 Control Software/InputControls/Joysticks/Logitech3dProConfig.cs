using JoystickInput;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.InputControls.Joysticks {
	public class Logitech3dProConfig : JoystickConfig {

		public override Twist Translate(Dictionary<JoystickControl, int> states) {
			Twist twist = new Twist();

			float speed = 1f - states[JoystickControl.Sliders0] / UInt16.MaxValue;

			float hat = getAngle(states[JoystickControl.PointOfViewControllers0]);
			twist.Linear.X = (hat < 0) ? 0f : (float)Math.Sin(hat);
			twist.Linear.Y = (hat < 0) ? 0f : (float)Math.Cos(hat);
			twist.Linear.Z = ((states[JoystickControl.Buttons3] > 0) ? 1f : 0f) + ((states[JoystickControl.Buttons2] > 0) ? -1f : 0f);

			twist.Angular.X = (float)states[JoystickControl.X] / ushort.MaxValue * 2f - 1f;
			twist.Angular.Y = -((float)states[JoystickControl.Y] / ushort.MaxValue * 2f - 1f);
			twist.Angular.Z = -((float)states[JoystickControl.RotationZ] / ushort.MaxValue * 2f - 1f);

			return twist;
		}

		private float getAngle(int id) {
			if (id < 0) return -1;
			float angle = id / 100;
			return (float)(angle * Math.PI / 180);
		}

	}
}
