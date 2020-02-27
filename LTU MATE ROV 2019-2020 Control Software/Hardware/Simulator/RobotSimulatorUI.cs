using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware.Simulator {
	public partial class RobotSimulatorUI : Form {

		private RobotSimulator simulator;
		private bool invokedClose = false;

		public RobotSimulatorUI(RobotSimulator simulator) {
			InitializeComponent();
			this.simulator = simulator;
		}

		private void RobotSimulatorUI_Load(object sender, EventArgs e) {
			simulator.RegisterDevice(new DigitalSensorSimulator(0, TestBtn0));
			simulator.RegisterDevice(new DigitalActuatorSimulator(3, Led));
		}

		private void RobotSimulatorUI_FormClosing(object sender, FormClosingEventArgs e) {
			if (invokedClose) return;
			invokedClose = true;
			simulator.Disconnect();
		}
	}
}
