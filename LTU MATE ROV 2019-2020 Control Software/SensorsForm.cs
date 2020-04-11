using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.DataTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTU_MATE_ROV_2019_2020_Control_Software {
	public partial class SensorsForm : Form {

		private ROV rov;

		public SensorsForm(ROV Robot) { //TODO rov can be null, or change
			InitializeComponent();
			rov = Robot;
		}

		private void SensorsForm_Load(object sender, EventArgs e) {
			timer1.Enabled = true;
		}

		private void timer1_Tick(object sender, EventArgs e) {
			TestBtnMeter.Value = rov.Button0.State;
			TestBtn2.Value = rov.Button1.State;

			//Vector3Data euler = rov.IMU.Euler;
			/*if (euler != null) {
					EulerX.Text = "X: " + euler.x.ToString("0.00").PadLeft(10) + "°";
					EulerY.Text = "Y: " + euler.y.ToString("0.00").PadLeft(10) + "°";
					EulerZ.Text = "Z: " + euler.z.ToString("0.00").PadLeft(10) + "°";
				}*/

			TempLabel.Text = "Temperature: " + rov.IMU.Temperature.ToString().PadLeft(4) + "°C";
			Vector3Data accel = rov.IMU.Accelerometer;
			if (accel != null) {
				AccelX.Text = "X: " + accel.x.ToString("0.00").PadLeft(10) + " m/s²";
				AccelY.Text = "Y: " + accel.y.ToString("0.00").PadLeft(10) + "m/s²";
				AccelZ.Text = "Z: " + accel.z.ToString("0.00").PadLeft(10) + "m/s²";
			}

			WaterTempLabel.Text = "Water Temp: " + rov.PressureSensor.Temperature.ToString("0.00").PadLeft(10) + "°C";
			PressureLabel.Text = "Pressure: " + rov.PressureSensor.Pressure.ToString("0.00").PadLeft(10) + " mBar";
			AltitudeLabel.Text = "Altitude: " + rov.PressureSensor.Altitude.ToString("0.00").PadLeft(10) + " m above mean sea";
			DepthLabel.Text = "Depth: " + rov.PressureSensor.Depth.ToString("0.00").PadLeft(10) + " m";
		}
	}
}
