using CustomLogger;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.InputControls {
	public class InputThread : ThreadSwitcher<InputProgram> {

		//private volatile InputProgram inputDevice;
		/*public InputProgram InputDevice {
			get => process;//inputDevice;
			set {
				lock (this) {
					if (inputDevice != null) inputDevice.Stop();
					inputDevice = value;
					if (inputDevice != null) inputDevice.Start(priority);
				}
			}
		}*/
		public InputProgram InputDevice {
			get => Process;
			set {
				if (value == null) Log.Info("Input program deselected.");
				else Log.Info("New input program selected: \"" + value.Name + "\"");
				Process = value;
			}
		}

		public Twist Input {
			get {
				InputProgram device = Process; //inputDevice;
				if (device != null) {
					return device.Input;
				}

				return new Twist();
			}
		}

		public bool GripperLOpen {
			get {
				InputProgram device = Process;
				if(device != null) {
					return device.GripperLOpen;
				}

				return true;
			}
		}

		public bool GripperROpen {
			get {
				InputProgram device = Process;
				if (device != null) {
					return device.GripperROpen;
				}

				return true;
			}
		}

		public bool NetOpen {
			get {
				InputProgram device = Process;
				if(device != null) {
					return device.NetOpen;
				}

				return false;
			}
		}

		//private readonly ThreadPriority priority;

		public InputThread(ThreadPriority Priority = ThreadPriority.Normal) : base(Priority) {
			//this.priority = priority;
		}

		protected override void ProcessStopped(InputProgram Process) {
			
		}

		protected override void ProcessStarting(InputProgram Process) {
			
		}
		/*
public void StopAsync() {
	lock (this) {
		inputDevice?.StopAsync();
	}
}

public void Stop() {
	lock (this) {
		inputDevice?.Stop();
	}
}
*/
	}
}