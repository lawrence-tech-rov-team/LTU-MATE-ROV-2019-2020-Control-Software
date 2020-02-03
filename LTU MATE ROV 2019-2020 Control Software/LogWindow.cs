﻿using CustomLogger;
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

		public LogLevel LogLevel { get; private set; } = LogLevel.Info;
		public LogFormat LogFormat { get; } = new LogFormat();

		public LogWindow() {
			InitializeComponent();
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
		//TODO logging should NOT save calling class name, but just the thread name
		private void LogWindow_Load(object sender, EventArgs e) {
			int y = 21;
			foreach(LogLevel level in EnumUtil.GetValues<LogLevel>()) {
				if (level == LogLevel.None) continue;
				RadioButton box = new RadioButton();
				box.Parent = LogLevelsGroup;
				box.Location = new Point(6, y);
				box.Text = level.ToString();
				box.Checked = (level == LogLevel);
				box.CheckedChanged += 
					(object checkSender, EventArgs checkArgs) => {
						if (box.Checked) LogLevel = level;
					};

				y += 27;
			}
		}

	}
}
