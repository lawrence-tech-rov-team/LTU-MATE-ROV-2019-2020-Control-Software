using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software {
	public static class ThreadHelper {

		public static Thread StartNewThread(string ThreadName, bool IsBackground, ParameterizedThreadStart start, ThreadPriority priority = ThreadPriority.Normal) {
			Thread th = new Thread(start);
			th.IsBackground = IsBackground;
			th.Name = ThreadName;
			th.Start();
			
			return th;
		}

		public static Thread StartNewThread(string ThreadName, bool IsBackground, ThreadStart start, ThreadPriority priority = ThreadPriority.Normal) {
			Thread th = new Thread(start);
			th.IsBackground = IsBackground;
			th.Name = ThreadName;
			th.Start();

			return th;
		}

	}
}
