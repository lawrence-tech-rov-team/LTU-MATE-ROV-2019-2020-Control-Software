using LTU_MATE_ROV_2019_2020_Control_Software.InputControls;
using LTU_MATE_ROV_2019_2020_Control_Software.Robot;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Controls {
	public class ControlsThread : ThreadedProcess {

		private InputThread inputThread;
		private RobotThread robotThread;

		public ControlsThread(InputThread Input, RobotThread Robot, ThreadPriority Priority = ThreadPriority.Normal) : base("Controls Thread", Priority) {
			inputThread = Input;
			robotThread = Robot;
			robotThread.OnConnected += RobotThread_OnConnected;
		}

		protected override void Initialize() {
			
		}

		protected override bool Loop() {
			ROV robot = robotThread.Robot;
			if (robot != null) {
				Twist input = inputThread.Input;
				//robot.ServoA1.Enable = true;
				ushort pulse = (ushort)(1500 + (short)(500 * input.Linear.X));
				robot.ServoA1.Pulse = pulse;
				robot.ServoD1.Pulse = pulse;
			}

			return Sleep(10);
		}

		protected override void Cleanup() {
			
		}

		private void RobotThread_OnConnected() {
			ROV robot = robotThread.Robot;
			if (robot != null) {
				robot.ServoA1.Enabled = true;
				robot.ServoD1.Enabled = true;
			}
		}

	}
}
