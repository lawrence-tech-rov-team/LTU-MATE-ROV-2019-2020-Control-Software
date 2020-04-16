using LTU_MATE_ROV_2019_2020_Control_Software.InputControls;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Robot {
	public class RobotThread : ThreadedProcess {

		public RobotThread(ThreadPriority Priority = ThreadPriority.Normal) : base("Robot Thread", Priority) {
		}

		protected override void Initialize() {
			throw new NotImplementedException();
		}

		protected override bool Loop() {
			throw new NotImplementedException();
		}

		protected override void Cleanup() {
			throw new NotImplementedException();
		}

	}

}
