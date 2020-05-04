﻿using LTU_MATE_ROV_2019_2020_Control_Software.InputControls;
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
		public volatile GripperPosition GripperL;
		public volatile GripperPosition GripperR;
		public volatile GripperPosition Net;

		public ControlsThread(InputThread Input, RobotThread Robot, ThreadPriority Priority = ThreadPriority.Normal) : base("Controls Thread", Priority) {
			inputThread = Input;
			robotThread = Robot;
			robotThread.OnConnected += RobotThread_OnConnected;
			robotThread.OnDisconnecting += RobotThread_OnDisconnecting;
		}

		protected override void Initialize() {
			
		}

		protected override bool Loop() {
			ROV robot = robotThread.Robot;
			if ((robot != null) && (Enabled)) {
				//Grab all inputs at once
				Twist input = inputThread.Input;
				bool gripperLOpen = inputThread.GripperLOpen;
				bool gripperROpen = inputThread.GripperROpen;
				bool netOpen = inputThread.NetOpen;

				//Move servos for direction control
				robot.PwmA1.DutyCycle = input.Linear.X;
				robot.PwmD1.DutyCycle = input.Linear.X;

				//Move gripper L
				GripperPosition gripperL = GripperL;
				if (gripperL != null) {
					robot.LeftGripperServo.Angle = (gripperLOpen ? gripperL.Open : gripperL.Closed);
				}

				//Move gripper R
				GripperPosition gripperR = GripperR;
				if (gripperR != null) {
					robot.RightGripperServo.Angle = (gripperROpen ? gripperR.Open : gripperR.Closed);
				}

				//Move Net
				GripperPosition net = Net;
				if(net != null) {
					robot.NetServo.Angle = (netOpen ? net.Open : net.Closed);
				}
			}

			return Sleep(10);
		}

		protected override void Cleanup() {
			
		}

		private void RobotThread_OnConnected(Robot.Hardware.Robot sender) {
			if((sender != null) && (sender is ROV rov)) {
				rov.FrontLeftServo.Enabled = true;
				rov.FrontRightServo.Enabled = true;
				rov.BackLeftServo.Enabled = true;
				rov.BackRightServo.Enabled = true;

				rov.FrontLeftThruster.Enabled = true;
				rov.FrontRightThruster.Enabled = true;
				rov.BackLeftThruster.Enabled = true;
				rov.BackRightThruster.Enabled = true;

				rov.LeftGripperServo.Enabled = true;
				rov.RightGripperServo.Enabled = true;
				rov.NetServo.Enabled = true;
			}
		}

		private void RobotThread_OnDisconnecting(Robot.Hardware.Robot sender) {
			if((sender != null) && (sender is ROV rov)) {
				rov.FrontLeftThruster.Stop();
				rov.FrontLeftThruster.Enabled = false;

				rov.FrontRightThruster.Stop();
				rov.FrontRightThruster.Enabled = false;

				rov.BackLeftThruster.Stop();
				rov.BackLeftThruster.Enabled = false;

				rov.BackRightThruster.Stop();
				rov.BackRightThruster.Enabled = false;
			}
		}

	}
}
