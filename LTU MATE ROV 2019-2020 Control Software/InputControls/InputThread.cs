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

		private volatile InputDevice inputDevice;
		public InputDevice InputDevice {
			get => inputDevice;
			set {
				lock (this) {
					if (inputDevice != null) inputDevice.Disconnect();
					inputDevice = value;
					if (inputDevice != null) inputDevice.Connect();
				}
			}
		}

		private volatile TwistWrapper input = new TwistWrapper();
		public Twist Input { get => input.Value; }

		private Thread thread;

		private volatile bool running = true;

		public InputThread(ThreadPriority priority) {
			thread = ThreadHelper.StartNewThread("Input Reader", true, InputLoop, priority);
			//Volatile.Write<IEthernetLayer>(ref ether, commInterface);
		}

		public void StopAsync() {
			running = false;
		}

		public void Stop() {
			StopAsync();
			thread.Join();
		}

		private void InputLoop() {
			//Init here, invoke events
			while (running) {
				lock (this) {
					if ((inputDevice != null) && (inputDevice.Update())) {
						input = new TwistWrapper(inputDevice.Value);
					} else {
						input = new TwistWrapper();
					}
				}

				Thread.Sleep(33);
			}
			//clean up, invoke events
			lock (this) {
				if (inputDevice != null) inputDevice.Disconnect();
			}
		}

		private class TwistWrapper {

			public Twist Value { get; }

			public TwistWrapper() {
				Value = new Twist();
			}

			public TwistWrapper(Twist twist) {
				twist.Linear.X = Constrain(twist.Linear.X);
				twist.Linear.Y = Constrain(twist.Linear.Y);
				twist.Linear.Z = Constrain(twist.Linear.Z);
				twist.Angular.X = Constrain(twist.Angular.X);
				twist.Angular.Y = Constrain(twist.Angular.Y);
				twist.Angular.Z = Constrain(twist.Angular.Z);
				Value = twist;
			}

			private float Constrain(float value) {
				return Math.Max(-1f, Math.Min(1f, value));
			}

		}

	}
}
