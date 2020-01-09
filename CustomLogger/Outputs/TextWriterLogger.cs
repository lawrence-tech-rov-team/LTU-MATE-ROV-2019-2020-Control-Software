using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLogger.Outputs {
	public abstract class TextWriterLogger : LogOutput {

		protected TextWriter Stream;

		public Encoding Encoding {
			get {
				if (Stream == null) return null;
				else return Stream.Encoding;
			}
		}
		public IFormatProvider FormatProvider {
			get {
				if (Stream == null) return null;
				else return Stream.FormatProvider;
			}
		}
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
