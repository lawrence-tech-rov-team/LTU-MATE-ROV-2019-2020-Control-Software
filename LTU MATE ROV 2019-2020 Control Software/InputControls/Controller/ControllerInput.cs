using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller_Wrapper;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;

namespace LTU_MATE_ROV_2019_2020_Control_Software.InputControls.Controller {
	public class ControllerInput : InputDevice {

		private Controller_Wrapper.Controller controller;
		public override string Name => (controller == null) ? "null (Controller)" : "Controller " + controller.PlayerNumber.ToNumber();

		private ControllerInput(Controller_Wrapper.Controller controller) {
			this.controller = controller;
		}

		public override void Connect() {
			
		}

		public override void Disconnect() {
			
		}

		public override bool Update() {
			if(controller.Connected && controller.Update()) {
				Value = Translate();
				return true;
			} else {
				return false;
			}
		}

		private Twist Translate() {
			Twist twist = new Twist();
			twist.Linear.X = controller.LeftThumbstick.Y;
			return twist;
		}

		public static InputDevice[] GetDevices() {
			return Controller_Wrapper.Controller.GetConnectedControllers().Select(x => new ControllerInput(x)).ToArray();
		}
	}
}
