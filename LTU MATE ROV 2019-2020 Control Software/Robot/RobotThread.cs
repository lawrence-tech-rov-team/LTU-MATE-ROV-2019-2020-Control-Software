﻿using LTU_MATE_ROV_2019_2020_Control_Software.InputControls;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.Robot;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Robot {
	public class RobotThread : ThreadSwitcher<ROV> {

		public event GenericEvent OnIdCollisionDetected;
		public event GenericEvent OnConnected;
		public event GenericEvent OnConnectFailed;
		public event GenericEvent OnDisconnected;
		public event GenericEvent OnTimeoutWarning;
		public event GenericEvent OnTimeout;
		
		public ROV Robot {
			get => Process;
			set => Process = value;
		}

		public RobotThread(ThreadPriority Priority = ThreadPriority.Normal) : base(Priority) {
		}

		protected override void ProcessStopped(ROV Process) {
			Process.OnIdCollisionDetected -= OnIdCollisionDetected;
			Process.OnConnected -= OnConnected;
			Process.OnConnectFailed -= OnConnectFailed;
			Process.OnDisconnected -= OnDisconnected;
			Process.OnTimeoutWarning -= OnTimeoutWarning;
			Process.OnTimeout -= OnTimeout;
		}

		protected override void ProcessStarting(ROV Process) {
			Process.OnIdCollisionDetected += OnIdCollisionDetected;
			Process.OnConnected += OnConnected;
			Process.OnConnectFailed += OnConnectFailed;
			Process.OnDisconnected += OnDisconnected;
			Process.OnTimeoutWarning += OnTimeoutWarning;
			Process.OnTimeout += OnTimeout;
		}

	}

}
