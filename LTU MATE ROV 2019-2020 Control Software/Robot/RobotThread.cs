using CustomLogger;
using LTU_MATE_ROV_2019_2020_Control_Software.InputControls;
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

		public event IdCollisionEvent OnIdCollisionDetected;
		public event RobotEvent OnConnected;
		public event RobotEvent OnDisconnecting;
		public event GenericEvent OnConnectFailed;
		public event GenericEvent OnDisconnected;
		public event GenericEvent OnTimeoutWarning;
		public event GenericEvent OnTimeout;
		public event ErrorEvent OnErrorReceived;
		
		public ROV Robot {
			get => Process;
			set {
				if (value == null) Log.Info("Robot deselected.");
				else Log.Info("New robot selected: IsSimulator = " + value.IsSimulator.ToString());
				Process = value;
			}
		}

		public RobotThread(ThreadPriority Priority = ThreadPriority.Normal) : base(Priority) {
		}

		protected override void ProcessStopped(ROV Process) {
			Process.OnIdCollisionDetected -= OnIdCollisionDetected;
			Process.OnConnected -= OnConnected;
			Process.OnDisconnecting -= OnDisconnecting;
			Process.OnConnectFailed -= OnConnectFailed;
			Process.OnDisconnected -= OnDisconnected;
			Process.OnTimeoutWarning -= OnTimeoutWarning;
			Process.OnTimeout -= OnTimeout;
			Process.OnErrorsReceived -= OnErrorReceived;
		}

		protected override void ProcessStarting(ROV Process) {
			Process.OnIdCollisionDetected += OnIdCollisionDetected;
			Process.OnConnected += OnConnected;
			Process.OnDisconnecting += OnDisconnecting;
			Process.OnConnectFailed += OnConnectFailed;
			Process.OnDisconnected += OnDisconnected;
			Process.OnTimeoutWarning += OnTimeoutWarning;
			Process.OnTimeout += OnTimeout;
			Process.OnErrorsReceived += OnErrorReceived;
		}

	}

}
