using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLogger.Outputs {

	/// <summary>
	/// An abstract class used to implement a TextWriter output as a logger output.
	/// </summary>
	public abstract class TextWriterLogger : LogOutput {

		/// <summary>
		/// The stream that is used as the output.
		/// </summary>
		protected TextWriter Stream;

		/// <summary>
		/// The character encoding in which the stream is written.
		/// </summary>
		public Encoding Encoding {
			get {
				if (Stream == null) return null;
				else return Stream.Encoding;
			}
		}

		/// <summary>
		/// Gets an object that controls formatting.
		/// </summary>
		public IFormatProvider FormatProvider {
			get {
				if (Stream == null) return null;
				else return Stream.FormatProvider;
			}
		}

		/// <summary>
		/// Gets or sets the terminator string used by the TextWriter.
		/// </summary>
		public string NewLine {
			get {
				if (Stream == null) return null;
				else return Stream.NewLine;
			}
			set {
				if (Stream != null) Stream.NewLine = value;
			}
		}


		public TextWriterLogger(TextWriter stream) {
			this.Stream = stream;
		}
		
		internal override void Dispose() {
			if (Stream != null) {
				Stream.Flush();
				Stream.Dispose();
			}
			Stream = null;
		}

		internal override void Flush() {
			if (Stream != null) Stream.Flush();
		}

		internal override void WriteText(string msg) {
			if (Stream != null) Stream.WriteLine(msg);
		}
	}
}
