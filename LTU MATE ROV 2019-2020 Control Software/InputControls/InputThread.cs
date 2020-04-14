using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.InputControls {
	public class InputThread {

		private volatile InputProgram inputDevice;
		public InputProgram InputDevice {
			get => inputDevice;
			set {
				lock (this) {
					if (inputDevice != null) inputDevice.Stop();
					inputDevice = value;
					if (inputDevice != null) inputDevice.Start(priority);
				}
			}
		}

		public Twist Input {
			get {
				InputProgram device = inputDevice;
				if (device != null) {
					TwistWrapper wrapper = device.Value;
					if (wrapper != null) {
						return wrapper.Value;
					}
				}

				return new Twist();
			}
		}

		private readonly ThreadPriority priority;

		public InputThread(ThreadPriority priority = ThreadPriority.Normal) {
			this.priority = priority;
		}

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
	
	}
}