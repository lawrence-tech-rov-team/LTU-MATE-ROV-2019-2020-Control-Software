using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLogger.Outputs {
	/// <summary>
	/// Writes the log to a file.
	/// </summary>
	public class FileLogger : TextWriterLogger{

		private FileLogger(TextWriter stream) : base(stream) {

		}

		/// <summary>
		/// Attempts to save the log to the specified file. Returns null if the specified file could not be found.
		/// </summary>
		/// <param name="file"></param>
		/// <returns></returns>
		public static FileLogger LoadFile(string file) {
			try {
				string path = Path.GetFullPath(file);
				if (File.Exists(path)) return null;
				string folder = Path.GetDirectoryName(path);
				if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);
				StreamWriter stream = new StreamWriter(path);
				if (stream == null) return null;
				stream.AutoFlush = true;
				return new FileLogger(stream);
			} catch(Exception ex) {
				Console.Error.Write("Error while initializing file logger: \"" + (file ?? "null") + "\"");
				Console.Error.WriteLine(ex.Message);
				Console.Error.WriteLine(ex.StackTrace);

				return null;
			}
		}

	}
}
