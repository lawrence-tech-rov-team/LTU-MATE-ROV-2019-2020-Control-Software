using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CustomLogger {
	public abstract class LogOutput {

		public LogLevel LogLevel { get; set; } = LogLevel.Info;
		private LogFormat format = new LogFormat();
		public LogFormat LogFormat {
			get => format;
			set { if (value != null) format = value; }
		}
		//private LogLevel minLogLevel;
		/*public LogLevel MinimumLogLevel { get; set; }
		public LogLevel MaximumLogLevel {
			get;
			set;
		}*/

		internal abstract void Dispose();

		//todo Change output style

		internal abstract void Flush();

		internal abstract void WriteText(string msg);

		internal void Log(LogLevel level, string msg, string ThreadName, int ThreadId, ThreadPriority ThreadPriority) {
			if (level <= LogLevel) {
				string header = format.GetHeader(level, ThreadName, ThreadId, ThreadPriority);
				WriteText(header + msg);
			}
		}
	}
}
