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
		public volatile bool Enabled = true;
		public volatile GripperPosition Gripper;

		public ControlsThread(InputThread Input, RobotThread Robot, ThreadPriority Priority = ThreadPriority.Normal) : base("Controls Thread", Priority) {
			inputThread = Input;
			robotThread = Robot;
			robotThread.OnConnected += RobotThread_OnConnected;
		}

		protected override void Initialize() {
			
		}

		protected override bool Loop() {
			ROV robot = robotThread.Robot;
			if ((robot != null) && (Enabled)) {
				//Grab all inputs at once
				Twist input = inputThread.Input;
				bool gripperOpen = inputThread.GripperOpen;

				//Move servos for direction control
				robot.ServoA1.Position = input.Linear.X;
				robot.ServoD1.Position = input.Linear.X;

				//Move gripper
				GripperPosition gripper = Gripper;
				if (gripper != null) {
					robot.ServoA2.Position = ServoAngleToPosition(gripperOpen ? gripper.Open : gripper.Closed);
				}
			}

			return Sleep(10);
		}

		private static float ServoAngleToPosition(ushort angle) {
			return angle / 270f;
		}

		protected override void Cleanup() {
			
		}

		private void RobotThread_OnConnected(Robot.Hardware.Robot sender) {
			if((sender != null) && (sender is ROV rov)) {
				rov.ServoA1.Enabled = true;
				rov.ServoA2.Enabled = true;
				rov.ServoD1.Enabled = true;
			}
		}

	}
}
