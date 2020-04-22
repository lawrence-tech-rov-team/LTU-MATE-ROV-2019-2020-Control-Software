using CustomLogger;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTU_MATE_ROV_2019_2020_Control_Software {

	public partial class LogWindowForm : Form {

		private LogWindow log;

		public LogWindowForm(LogWindow log) {
			this.log = log;
			InitializeComponent();

			int y = 21;
			foreach (LogLevel level in EnumUtil.GetValues<LogLevel>()) {
				if (level == LogLevel.None) continue;
				RadioButton box = new RadioButton();
				box.Parent = LogLevelsGroup;
				box.Location = new Point(6, y);
				box.Text = level.ToString();
				//box.Checked = (level == LogLevel);
				box.CheckedChanged += (object checkSender, EventArgs checkArgs) => {
					if (box.Checked) log.LogLevel = level;
				};

				log.LogLevelChanged += (LogLevel NewLevel) => {
					bool sameLevel = (NewLevel == level);
					if (box.Checked != sameLevel) box.Checked = sameLevel;
				};

				y += 27;
			}
		}

		public void Log(string msg) {
			LogTextBox.Invoke(new Action(() => {
				if (LogTextBox.Text.Length + msg.Length > 4000) {
					LogTextBox.Text = LogTextBox.Text.Substring(2000);
				}

				LogTextBox.AppendText(msg);
				LogTextBox.AppendText(Environment.NewLine);
			}));
		}

		private void LogWindow_Load(object sender, EventArgs e) {

		}

		private void LogWindowForm_FormClosing(object sender, FormClosingEventArgs e) {
			log.Close();
		}
	}

	public class LogWindow : LogOutput {

		public delegate void LogLevelEvent(LogLevel NewLevel);
		public event LogLevelEvent LogLevelChanged;

		private LogLevel level = LogLevel.Info;
		public LogLevel LogLevel {
			get => level;
			set {
				level = value;
				LogLevelChanged?.Invoke(value);
			}
		}
		public LogFormat LogFormat { get; set; } = new LogFormat();

		private volatile LogWindowForm window;

		public void Open() {
			lock (this) {
				window = new LogWindowForm(this);
				LogLevelChanged?.Invoke(level);
				window.Show();
			}
		}

		public void Close() {
			lock (this) {
				if(window != null) {
					//Prevents stack overflow from circular calling. This way it only loops once before returning when being called from the form itself.
					LogWindowForm form = window;
					window = null;
					form.Close();
				}
			}
		}

		public void Log(string msg) {
			lock (this) {
				window?.Log(msg);
			}
		}
	}

}
