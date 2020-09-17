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

		private bool gripperLState = true;
		private bool gripperLDB = true;

		private bool gripperRState = true;
		private bool gripperRDB = true;

		private bool netState = false;
		private bool netDB = true;

		private ControllerProgram(Controller_Wrapper.Controller controller) {
			this.controller = controller;
		}

		protected override void Setup() {
			
		}

		protected override bool Run() {
			if(controller.Connected && controller.Update()) {
				Input = TranslateTwist();
				GripperLOpen = ToggleState(ref gripperLState, ref gripperLDB, controller.LeftShoulder);
				GripperROpen = ToggleState(ref gripperRState, ref gripperRDB, controller.RightShoulder);
				NetOpen = ToggleState(ref netState, ref netDB, controller.Y);
				return Sleep(33);
			} else {
				return false;
			}
		}

		protected override void Finish() {
			Input = new Twist();
		}

		private Twist TranslateTwist() {
			Twist twist = new Twist();
			twist.Linear.X = controller.LeftThumbstick.Y;
			return twist;
		}

		private static bool ToggleState(ref bool state, ref bool db, bool button) {
			if (button) {
				if (db) {
					db = false;
					state = !state;
				}
			} else {
				db = true;
			}

			return state;
		}

		public static InputProgram[] GetPrograms() {
			return Controller_Wrapper.Controller.GetConnectedControllers().Select(x => new ControllerProgram(x)).ToArray();
		}

	}
}
