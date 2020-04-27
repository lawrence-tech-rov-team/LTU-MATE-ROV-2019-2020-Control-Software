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
		private volatile bool invokeClose = false;

		public RobotSimulatorUI(RobotThread RobotThread) {
			InitializeComponent();
			robotThread = RobotThread;
			simulator = new RobotSimulator();
			invokeClose = false;
			simulator.OnDisconnect += () => {
				invokeClose = true;
			};
		}

		private void RobotSimulatorUI_Load(object sender, EventArgs e) {
			simulator.RegisterDevice(new DigitalSensorSimulator(54, Btn0));
			simulator.RegisterDevice(new DigitalSensorSimulator(55, Btn1));
			simulator.RegisterDevice(new DigitalActuatorSimulator(56, Led));
			simulator.RegisterDevice(new PressureSensorSimulator(57, PresTempBar, PressureBar));
			simulator.RegisterDevice(new ImuSimulator(
				/*Temperature*/		58, TempTrackBar, TempLabel, 
				/*Accelerometer*/	59, TrackBarX, TrackBarY, TrackBarZ,
				/*Magnetometer*/	60,
				/*Gyroscope*/		61,
				/*Euler*/			62,
				/*Linear Accel*/	63,
				/*Gravity*/			64,
				/*Quaternion*/		65
			));

			//A
			simulator.RegisterDevice(new ServoSimulator(0, 1, PositionA1));
			simulator.RegisterDevice(new ServoSimulator(2, 3, PositionA2));
			simulator.RegisterDevice(new ServoSimulator(4, 5, PositionA3));
			simulator.RegisterDevice(new ServoSimulator(6, 7, PositionA4));
			simulator.RegisterDevice(new ServoSimulator(8, 9, PositionA5));

			//B
			simulator.RegisterDevice(new ServoSimulator(10, 11, PositionB1));
			simulator.RegisterDevice(new ServoSimulator(12, 13, PositionB2));
			simulator.RegisterDevice(new ServoSimulator(14, 15, PositionB3));
			simulator.RegisterDevice(new ServoSimulator(16, 17, PositionB4));
			simulator.RegisterDevice(new ServoSimulator(18, 19, PositionB5));
			simulator.RegisterDevice(new ServoSimulator(20, 21, PositionB6));

			//C
			simulator.RegisterDevice(new ServoSimulator(22, 23, PositionC1));
			simulator.RegisterDevice(new ServoSimulator(24, 25, PositionC2));
			simulator.RegisterDevice(new ServoSimulator(26, 27, PositionC3));
			simulator.RegisterDevice(new ServoSimulator(28, 29, PositionC4));
			simulator.RegisterDevice(new ServoSimulator(30, 31, PositionC5));
			simulator.RegisterDevice(new ServoSimulator(32, 33, PositionC6));
			simulator.RegisterDevice(new ServoSimulator(34, 35, PositionC7));
			simulator.RegisterDevice(new ServoSimulator(36, 37, PositionC8));

			//D
			simulator.RegisterDevice(new ServoSimulator(38, 39, PositionD1));
			simulator.RegisterDevice(new ServoSimulator(40, 41, PositionD2));
			simulator.RegisterDevice(new ServoSimulator(42, 43, PositionD3));
			simulator.RegisterDevice(new ServoSimulator(44, 45, PositionD4));
			simulator.RegisterDevice(new ServoSimulator(46, 47, PositionD5));
			simulator.RegisterDevice(new ServoSimulator(48, 49, PositionD6));
			simulator.RegisterDevice(new ServoSimulator(50, 51, PositionD7));
			simulator.RegisterDevice(new ServoSimulator(52, 53, PositionD8));

			robotThread.Robot = new ROV(simulator);
			UpdateTimer.Start();
		}

		private void RobotSimulatorUI_FormClosing(object sender, FormClosingEventArgs e) {
			//if (invokedClose) return;
			//invokedClose = true;
			UpdateTimer.Stop();
			simulator.Disconnect();
			simulator.Disconnect();
		}

		private void connectToolStripMenuItem_Click(object sender, EventArgs e) {
			robotThread.Robot = new ROV(simulator);
		}

		private void UpdateTimer_Tick(object sender, EventArgs e) {
			if (invokeClose) Close();
			else simulator.Update();
		}
	}
}
