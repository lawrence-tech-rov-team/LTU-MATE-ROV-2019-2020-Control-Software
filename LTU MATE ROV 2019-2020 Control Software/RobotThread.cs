using LTU_MATE_ROV_2019_2020_Control_Software.InputControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software {
	public static class RobotThread {

		private static Thread thread;

		//private static IController controller = null;
		private static volatile bool runThread = false;

		private static volatile bool ShouldSwitchControls = false;
		private static readonly object ControlLock = new object();

		private static volatile bool RequestInputData = false;
		private static volatile InputControlData RequestedInputData = null;
		//private static volatile IKeyboardListener keyboardListener = null;
		private static readonly object InputDataLock = new object();
		

		static RobotThread() {

		}

		public static bool Start() {
			if (thread != null) return true;
			runThread = true;
			//thread = ThreadHelper.StartNewThread("Robot", false, Loop);
			return thread != null;
		}

		public static void RequestStop() {
			//AKA set a flag to stop the thread without waiting for it end.
			runThread = false;
		}

		public static void Stop() {
			runThread = false;
			thread.Join();
		}
/*
		public static void SetControllerType(ControllerType type, IKeyboardListener keyboard = null) {
			lock (ControlLock) {
				SwitchControlType = type;
				keyboardListener = keyboard;
				ShouldSwitchControls = true;
			}
		}
		*/
		public static InputControlData GetInputData() {
			lock (InputDataLock) {
				RequestInputData = true;
				while (RequestInputData == true) ;
				return RequestedInputData;
			}
		}

		private static void Loop() {
			while (runThread) {
				/*if (controller != null) {
					controller.Update();
				}

				if (RequestInputData) {
					if (controller == null) {
						RequestedInputData = null;
					} else {
						RequestedInputData = new InputControlData(controller.ForwardPower, controller.SidePower);
					}
					RequestInputData = false;
				}*/
/*
				ControllerType? swap = null;
				IKeyboardListener keyboard = null;
				lock (ControlLock) {
					if (ShouldSwitchControls) {
						swap = SwitchControlType;
						keyboard = keyboardListener;
						ShouldSwitchControls = false;
					}
				}

				if(swap != null) {
					if (controller != null) controller.Disconnect();
					controller = ((ControllerType)swap).GetNewController();
					if (!controller.Connect()) { //TODO crashes if doesn't exist
						Console.WriteLine("Failed to connect to control device!");
						controller = null;
					}else if(controller is KeyboardController) {
						((KeyboardController)controller).KeyListener = keyboard;
					}
				}*/

				Thread.Sleep(34); //TODO temporary for proof of concept
			}
		}

	}

	public class InputControlData {
		public float ForwardThrust;
		public float SideThrust;

		public InputControlData() {

		}
		
		public InputControlData(float f, float s) {
			ForwardThrust = f;
			SideThrust = s;
		}
	}
}
