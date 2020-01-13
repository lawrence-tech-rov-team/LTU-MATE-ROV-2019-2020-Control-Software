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
	public partial class LogWindow : Form, LogOutput {

		private ConcurrentDictionary<LogLevel, bool> levels = new ConcurrentDictionary<LogLevel, bool>();

		public LogWindow() {
			InitializeComponent();
		}

		private void LogWindow_Load(object sender, EventArgs e) {
			int y = 21;
			foreach(LogLevel level in EnumUtil.GetValues<LogLevel>()) {
				levels[level] = false;
				if (level == LogLevel.None) continue;
				CheckBox box = new CheckBox();
				box.Parent = LogLevelsGroup;
				box.Location = new Point(6, y);
				box.Text = level.ToString();
				bool chcked = (level < LogLevel.Info);
				box.Checked = chcked;
				levels[level] = chcked;
				box.CheckedChanged += 
					(object checkSender, EventArgs checkArgs) => {
						levels[level] = box.Checked;
					};

				y += 27;
			}
		}
	}
}
