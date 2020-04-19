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

		public event GenericEvent IdCollisionDetected;
		public event GenericEvent RobotStarted;
		public event GenericEvent RobotStopped;
		public event GenericEvent TimeoutWarning;
		public event GenericEvent RobotTimeout;
		
		private volatile ROV robot;
		public ROV Robot {
			get => Process;
			set => Process = value;
		}

		public RobotThread(ThreadPriority Priority = ThreadPriority.Normal) : base(Priority) {
		}

		protected override void ProcessStopped(ROV Process) {
			Process.OnIdCollisionDetected -= IdCollisionDetected;
			Process.OnConnected -= RobotStarted;
			Process.OnDisconnected -= RobotStopped;
			Process.OnTimeoutWarning -= TimeoutWarning;
			Process.OnTimeout -= RobotTimeout;
		}

		protected override void ProcessStarting(ROV Process) {
			Process.OnIdCollisionDetected += IdCollisionDetected;
			Process.OnConnected += RobotStarted;
			Process.OnDisconnected += RobotStopped;
			Process.OnTimeoutWarning += TimeoutWarning;
			Process.OnTimeout += RobotTimeout;
		}

	}

}
