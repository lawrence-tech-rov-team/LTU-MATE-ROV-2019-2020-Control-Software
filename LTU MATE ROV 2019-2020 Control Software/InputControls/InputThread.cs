using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.InputControls {
	public class InputThread {

		//public delegate void GenericEvent();

		private volatile InputProgram inputDevice;
		public InputProgram InputDevice {
			get => inputDevice;
			set {
				lock (this) {
					if (inputDevice != null) Stop();
					inputDevice = value;
					if (inputDevice != null) Start();
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

		private Thread thread;
		private readonly ThreadPriority priority;

		public InputThread(ThreadPriority priority) {
			this.priority = priority;
		}

		private void Start() {
			inputDevice.ShouldExit = false;
			thread = ThreadHelper.StartNewThread("Input Reader", true, InputLoop, priority);
		}

		public void StopAsync() {
			lock (this) {
				InputProgram device = inputDevice;
				if (device != null) device.ShouldExit = true;
			}
		}

		public void Stop() {
			lock (this) {
				StopAsync();
				thread.Join();
			}
		}

		private void InputLoop() {
			InputProgram program = inputDevice;
			if (program == null) return;
			try {
				program.Initialize();
				while (!program.ShouldExit) {
					if (!program.Loop()) break;
					/*lock (this) {
						if ((inputDevice != null) && (inputDevice.Update())) {
							input = new TwistWrapper(inputDevice.Value);
						} else {
							input = new TwistWrapper();
						}
					}*/

					//Thread.Sleep(33);
				}
				program.Cleanup();
			} catch (Exception ex) {
				Console.WriteLine("Input thread threw an exception:");
				Console.WriteLine(ex.Message);
				Console.WriteLine(ex.StackTrace);
			}
		}

	}
}