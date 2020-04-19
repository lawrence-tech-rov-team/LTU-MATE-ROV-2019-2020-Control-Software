using LTU_MATE_ROV_2019_2020_Control_Software.Robot;
using LTU_MATE_ROV_2019_2020_Control_Software.Simulator.Actuators;
using LTU_MATE_ROV_2019_2020_Control_Software.Simulator.Sensors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Simulator {
	public partial class RobotSimulatorUI : Form {

		private RobotThread robotThread;
		private RobotSimulator simulator;
		//private bool invokedClose = false;

		public RobotSimulatorUI(RobotThread RobotThread) {
			InitializeComponent();
			robotThread = RobotThread;
			simulator = new RobotSimulator();
		}

		private void RobotSimulatorUI_Load(object sender, EventArgs e) {
			simulator.RegisterDevice(new DigitalSensorSimulator(0, Btn0));
			simulator.RegisterDevice(new DigitalSensorSimulator(1, Btn1));
			simulator.RegisterDevice(new DigitalActuatorSimulator(2, Led));
			simulator.RegisterDevice(new PressureSensorSimulator(3, PresTempBar, PressureBar));
			simulator.RegisterDevice(new ImuSimulator(4, 5, TempTrackBar, TempLabel, TrackBarX, TrackBarY, TrackBarZ));

			//A
			simulator.RegisterDevice(new ServoSimulator(6, 7, PositionA1));
			simulator.RegisterDevice(new ServoSimulator(8, 9, PositionA2));
			simulator.RegisterDevice(new ServoSimulator(10, 11, PositionA3));
			simulator.RegisterDevice(new ServoSimulator(12, 13, PositionA4));
			simulator.RegisterDevice(new ServoSimulator(14, 15, PositionA5));

			//B
			simulator.RegisterDevice(new ServoSimulator(16, 17, PositionB1));
			simulator.RegisterDevice(new ServoSimulator(18, 19, PositionB2));
			simulator.RegisterDevice(new ServoSimulator(20, 21, PositionB3));
			simulator.RegisterDevice(new ServoSimulator(22, 23, PositionB4));
			simulator.RegisterDevice(new ServoSimulator(24, 25, PositionB5));
			simulator.RegisterDevice(new ServoSimulator(26, 27, PositionB6));

			//C
			simulator.RegisterDevice(new ServoSimulator(28, 29, PositionC1));
			simulator.RegisterDevice(new ServoSimulator(30, 31, PositionC2));
			simulator.RegisterDevice(new ServoSimulator(32, 33, PositionC3));
			simulator.RegisterDevice(new ServoSimulator(34, 35, PositionC4));
			simulator.RegisterDevice(new ServoSimulator(36, 37, PositionC5));
			simulator.RegisterDevice(new ServoSimulator(38, 39, PositionC6));
			simulator.RegisterDevice(new ServoSimulator(40, 41, PositionC7));
			simulator.RegisterDevice(new ServoSimulator(42, 43, PositionC8));

			//D
			simulator.RegisterDevice(new ServoSimulator(44, 45, PositionD1));
			simulator.RegisterDevice(new ServoSimulator(46, 47, PositionD2));
			simulator.RegisterDevice(new ServoSimulator(48, 49, PositionD3));
			simulator.RegisterDevice(new ServoSimulator(50, 51, PositionD4));
			simulator.RegisterDevice(new ServoSimulator(52, 53, PositionD5));
			simulator.RegisterDevice(new ServoSimulator(54, 55, PositionD6));
			simulator.RegisterDevice(new ServoSimulator(56, 57, PositionD7));
			simulator.RegisterDevice(new ServoSimulator(58, 59, PositionD8));

			robotThread.Robot = new ROV(simulator);
			UpdateTimer.Start();
		}

		private void RobotSimulatorUI_FormClosing(object sender, FormClosingEventArgs e) {
			//if (invokedClose) return;
			//invokedClose = true;
			UpdateTimer.Stop();
			simulator.Disconnect();
		}

		private void connectToolStripMenuItem_Click(object sender, EventArgs e) {
			robotThread.Robot = new ROV(simulator);
		}

		private void UpdateTimer_Tick(object sender, EventArgs e) {
			simulator.Update();
		}
	}
}
