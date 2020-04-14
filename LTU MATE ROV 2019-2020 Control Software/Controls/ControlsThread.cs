using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Controls {
	public class ControlsThread {

		private Thread thread;
		private ThreadPriority priority;
		private volatile bool running = true;

		public ControlsThread(ThreadPriority priority) {
			this.priority = priority;
			thread = ThreadHelper.StartNewThread("Controls Thread", true, ThreadLoop, priority);
		}

		public void StopAsync() {
			running = false;
		}

		public void Stop() {
			try {
				StopAsync();
				thread?.Join();
			} catch (Exception) { }
		}

		private void ThreadLoop() {
			while (running) {

			}
		}

	}
}
