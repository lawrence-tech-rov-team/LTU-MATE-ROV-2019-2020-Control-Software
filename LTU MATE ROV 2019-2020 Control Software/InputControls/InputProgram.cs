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
using System.Windows.Forms;

namespace LTU_MATE_ROV_2019_2020_Control_Software.InputControls {
	public abstract class InputProgram : ThreadedProcess {

		private volatile TwistWrapper Value = new TwistWrapper();
		public Twist Input { get => Value.Value; protected set => Value = new TwistWrapper(value); }

		private volatile bool gripperLOpen = true;
		public bool GripperLOpen { get => gripperLOpen; protected set => gripperLOpen = value; }

		private volatile bool gripperROpen = true;
		public bool GripperROpen { get => gripperROpen; protected set => gripperROpen = value; }

		private volatile bool netOpen = false;
		public bool NetOpen { get => netOpen; protected set => netOpen = value; }

		public abstract string Name { get; }

		private List<ThreadMethodLinker> eventListeners = new List<ThreadMethodLinker>();

		protected Form GUI;

		public InputProgram(ThreadPriority Priority = ThreadPriority.Normal) : base("Input Reader", Priority) {

		}

		protected override sealed void MainThreadActivated() {
			GUI = CreateGUI();
			GUI?.Show();
		}

		protected override sealed void MainThreadDeactivated() {
			GUI?.Close();
			GUI = null;
		}

		protected override sealed void Initialize() {
			eventListeners.Clear();
			Setup();
		}

		protected override sealed bool Loop() {
			ProcessEvents();
			return Run();
		}

		protected override sealed void Cleanup() {
			Finish();
		}

		protected abstract void Setup();
		protected abstract bool Run();
		protected abstract void Finish();

		protected virtual Form CreateGUI() {
			return null;
		}


		protected override sealed bool SleepLoop() {
			ProcessEvents();
			return true;
		}

		protected void AddEventListener(ThreadMethodLinker linker) {
			eventListeners.Add(linker);
		}

		protected void ProcessEvents() {
			foreach (ThreadMethodLinker linker in eventListeners) {
				linker.ProcessEvent();
			}
		}

		public override sealed string ToString() {
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
