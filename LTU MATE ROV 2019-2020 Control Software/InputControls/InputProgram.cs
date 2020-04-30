using JoystickInput;
using LTU_MATE_ROV_2019_2020_Control_Software.Cameras;
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

		private volatile TwistWrapper Value = new TwistWrapper();
		public Twist Input { get => Value.Value; protected set => Value = new TwistWrapper(value); }

		private volatile bool gripperOpen = true;
		public bool GripperOpen { get => gripperOpen; protected set => gripperOpen = value; }

		public abstract string Name { get; }

		public InputProgram(ThreadPriority Priority = ThreadPriority.Normal) : base("Input Reader", Priority) {

		}

		public override string ToString() {
			return Name;
		}

		public static InputProgram[] GetAvailablePrograms(CameraThread Cameras) {
			List<InputProgram> devices = new List<InputProgram> {
				KeyboardProgram.InputDevice
			};

			devices.AddRange(Joysticks.JoystickProgram.GetPrograms());
			devices.AddRange(ControllerProgram.GetPrograms());
			devices.AddRange(RovProgram.GetPrograms(Cameras));

			devices.Sort((x, y) => x.Name.CompareTo(y.Name));
			return devices.ToArray();
		}

	}
}
