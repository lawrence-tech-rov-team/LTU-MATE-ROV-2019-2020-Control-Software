using JoystickInput;
using LTU_MATE_ROV_2019_2020_Control_Software.InputControls.Controller;
using LTU_MATE_ROV_2019_2020_Control_Software.InputControls.Joysticks;
using LTU_MATE_ROV_2019_2020_Control_Software.InputControls.Keyboard;
using LTU_MATE_ROV_2019_2020_Control_Software.Programs;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.InputControls {
	public abstract class InputProgram : ThreadedProcess {

		public TwistWrapper Value { get; private set; } = new TwistWrapper();
		protected Twist Input { get => Value.Value; set => Value = new TwistWrapper(value); }
		public abstract string Name { get; }
		//public volatile bool ShouldExit = false;
		//private Stopwatch timer = new Stopwatch();


		public InputProgram(ThreadPriority Priority = ThreadPriority.Normal) : base("Input Reader", Priority) {

		}


		//public abstract void Initialize();

		/// <summary> Returns true if the program should continue looping. </summary>
		//public abstract bool Loop();
		//public abstract void Cleanup();
/*
		/// <summary>
		/// Returns true if successful, false if was interrupted by an exit request.
		/// </summary>
		protected bool Sleep(long millis) {
			timer.Restart();
			while(timer.ElapsedMilliseconds < millis) {
				if (ShouldExit) return false;
				Thread.Sleep(1);
			}
			return true;
		}
		*/
		public override string ToString() {
			return Name;
		}

		public static InputProgram[] GetAvailablePrograms(/*ROV rov*/) {
			List<InputProgram> devices = new List<InputProgram> {
				KeyboardProgram.InputDevice
			};

			devices.AddRange(Joysticks.JoystickProgram.GetPrograms());
			devices.AddRange(ControllerProgram.GetPrograms());
			devices.AddRange(RovProgram.GetPrograms(/*rov*/));

			devices.Sort((x, y) => x.Name.CompareTo(y.Name));
			return devices.ToArray();
		}

	}
}
