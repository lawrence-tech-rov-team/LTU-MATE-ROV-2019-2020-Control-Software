using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Utils {
	public abstract class ThreadSwitcher<T> where T : ThreadedProcess {

		private volatile ThreadPriority priority;
		public ThreadPriority Priority {
			get => priority;
			set {
				lock (this) {
					priority = value;
					if (process != null) process.Priority = value;
				}
			}
		}

		private volatile T process;
		protected T Process {
			get => process;
			set {
				lock (this) {
					process?.Stop();
					ProcessStopped(process);
					process = value;
					if(process != null) {
						ProcessStarting(process);
						process.Start(priority);
					}
				}
			}
		}

		protected ThreadSwitcher(ThreadPriority Priority = ThreadPriority.Normal) {
			priority = Priority;
		}

		public void StopAsync() {
			lock (this) {
				process?.StopAsync();
			}
		}

		public void Stop() {
			lock (this) {
				process?.Stop();
			}
		}

		protected abstract void ProcessStopped(T Process);
		protected abstract void ProcessStarting(T Process);

	}
}
