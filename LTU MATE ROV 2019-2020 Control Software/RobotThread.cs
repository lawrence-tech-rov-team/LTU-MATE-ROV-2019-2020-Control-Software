using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software {
	public static class RobotThread {

		private static Thread thread;

		static RobotThread() {

		}

		public static bool Start() {
			thread = ThreadHelper.StartNewThread("Robot", false, Loop);
			return thread != null;
		}

		private static void Loop() {

		}

	}
}
