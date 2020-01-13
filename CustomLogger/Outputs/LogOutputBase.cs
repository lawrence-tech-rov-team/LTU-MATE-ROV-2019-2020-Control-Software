using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLogger.Outputs {
	public abstract class LogOutputBase : LogOutput {
		public LogLevel LogLevel { get; set; } = LogLevel.Info;

		private LogFormat format = new LogFormat();
		public LogFormat LogFormat {
			get => format;
			set {
				if (value != null) format = value;
			}
		}

		public abstract void Close();

		public abstract void Log(string msg);
	}
}
