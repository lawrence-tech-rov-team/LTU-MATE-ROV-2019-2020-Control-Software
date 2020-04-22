using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CustomLogger {
	public interface LogOutput {

		LogLevel LogLevel { get; set; }
		LogFormat LogFormat { get; set; }

		void Close();

		void Log(string msg);
	}
}
