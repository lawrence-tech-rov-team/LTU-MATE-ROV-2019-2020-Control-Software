using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLogger.Outputs {

	/// <summary>
	/// Writes the log to the console window.
	/// </summary>
	public class ConsoleLogger : TextWriterLogger {
		public ConsoleLogger() : base(Console.Out) {
		}

		internal override void Dispose() {
			Flush();
			Stream = null;
		}
	}
}
