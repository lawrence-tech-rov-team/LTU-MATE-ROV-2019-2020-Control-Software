using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller_Wrapper;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;

namespace LTU_MATE_ROV_2019_2020_Control_Software.InputControls.Controller {
	public class ControllerProgram : InputProgram {

		private Controller_Wrapper.Controller controller;
		public override string Name => (controller == null) ? "null (Controller)" : "Controller " + controller.PlayerNumber.ToNumber();

		private bool gripperState = true;
		private bool gripperDB = true;

		private ControllerProgram(Controller_Wrapper.Controller controller) {
			this.controller = controller;
		}

		protected override void Initialize() {
			
		}

		protected override bool Loop() {
			if(controller.Connected && controller.Update()) {
				Input = TranslateTwist();
				GripperOpen = TranslateGripper();
				return Sleep(33);
			} else {
				return false;
			}
		}

		protected override void Cleanup() {
			Input = new Twist();
		}

		private Twist TranslateTwist() {
			Twist twist = new Twist();
			twist.Linear.X = controller.LeftThumbstick.Y;
			return twist;
		}

		private bool TranslateGripper() {
			if (controller.A) {
				if (gripperDB) {
					gripperDB = false;
					gripperState = !gripperState;
				}
			} else {
				gripperDB = true;
			}

			return gripperState;
		}

		public static InputProgram[] GetPrograms() {
			return Controller_Wrapper.Controller.GetConnectedControllers().Select(x => new ControllerProgram(x)).ToArray();
		}

	}
}
