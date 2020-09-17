using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Programs.StartStop {
	public partial class StartStopGui : Form {

		private StartStopProgram program;

		public StartStopGui(StartStopProgram program) {
			InitializeComponent();
			this.program = program;
		}

		private void StartStopGui_Load(object sender, EventArgs e) {

		}

		private void StartBtn_Click(object sender, EventArgs e) {
			program.StartButtonClicked.Invoke();
		}

		private void StopBtn_Click(object sender, EventArgs e) {
			program.StopButtonClicked.Invoke();
		}
	}
}
