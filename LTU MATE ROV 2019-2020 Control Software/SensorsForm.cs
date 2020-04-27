using LTU_MATE_ROV_2019_2020_Control_Software.Robot;
using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.DataTypes;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTU_MATE_ROV_2019_2020_Control_Software {
	public partial class SensorsForm : Form {

		private RobotThread robotThread;

		public SensorsForm(RobotThread Robot) { //TODO rov can be null, or change 
			InitializeComponent();
			robotThread = Robot;
		}

		private void SensorsForm_Load(object sender, EventArgs e) {
			timer1.Enabled = true;
		}

		private void Timer1_Tick(object sender, EventArgs e) {
			ROV rov = robotThread.Robot;

			TestBtnMeter.Value = rov?.Button0?.State ?? false;
			TestBtn2.Value = rov?.Button1?.State ?? false;

			TempLabel.Text = "Temperature: " + ((rov == null) ? "----" : rov.IMU.Temperature.ToString().PadLeft(4)) + "°C";
			AccelVectorPanel.Vector = rov?.IMU?.Accelerometer ?? new Vector3();
			MagVectorPanel.Vector = rov?.IMU?.Magnetometer ?? new Vector3();
			GyroVectorPanel.Vector = rov?.IMU?.Gyroscope ?? new Vector3();
			EulerVectorPanel.Vector = rov?.IMU?.Euler ?? new Vector3();
			LinearVectorPanel.Vector = rov?.IMU?.LinearAccel ?? new Vector3();
			GravityVectorPanel.Vector = rov?.IMU?.Gravity ?? new Vector3();
			Quaternion quat = rov?.IMU?.Quaternion ?? new Quaternion();
			QuatVectorPanel.Vector = new Vector4(quat.X, quat.Y, quat.Z, quat.W);

			WaterTempLabel.Text = "Water Temp: " + ((rov == null) ? "----------" : rov.PressureSensor.Temperature.ToString("0.00").PadLeft(10)) + "°C";
			PressureLabel.Text = "Pressure: " + ((rov == null) ? "----------" : rov.PressureSensor.Pressure.ToString("0.00").PadLeft(10)) + " mBar";
			AltitudeLabel.Text = "Altitude: " + ((rov == null) ? "----------" : rov.PressureSensor.Altitude.ToString("0.00").PadLeft(10)) + " m above mean sea";
			DepthLabel.Text = "Depth: " + ((rov == null) ? "----------" : rov.PressureSensor.Depth.ToString("0.00").PadLeft(10)) + " m";
		}
	}
}
