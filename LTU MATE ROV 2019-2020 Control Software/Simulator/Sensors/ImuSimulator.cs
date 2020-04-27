using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware;
using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Simulator.Sensors {
	public class ImuSimulator : ISimulatorDevice {
		public override IRegister[] Registers => new IRegister[] {
			TemperatureRegister,
			AccelerometerRegister
		};

		private Label tempFeedbackLabel;
		private WritableRegister<Int8Data> TemperatureRegister;
		private WritableRegister<Imu16Vector3Data> MagnetometerRegister;
		private WritableRegister<Imu16Vector3Data> GyroscopeRegister;
		private WritableRegister<Imu16Vector3Data> EulerRegister;
		private WritableRegister<Imu100Vector3Data> AccelerometerRegister;
		private WritableRegister<Imu100Vector3Data> LinearAccelRegister;
		private WritableRegister<Imu100Vector3Data> GravityRegister;
		private WritableRegister<ImuQuaternionData> QuaternionRegister;
		private float accelX = 0f;
		private float accelY = 0f;
		private float accelZ = 0f;

		public ImuSimulator(byte TemperatureId, byte accelId, TrackBar TemperatureTrackBar, Label TemperatureFeedbackLabel, TrackBar trackBarX, TrackBar trackBarY, TrackBar trackBarZ) {
			TemperatureRegister = new WritableRegister<Int8Data>(TemperatureId, 0f);
			this.tempFeedbackLabel = TemperatureFeedbackLabel;

			if (TemperatureTrackBar.Maximum < sbyte.MaxValue) {
				TemperatureTrackBar.Maximum = sbyte.MaxValue;
				TemperatureTrackBar.Value = sbyte.MaxValue;
				TemperatureTrackBar.Minimum = sbyte.MinValue;
			} else {
				TemperatureTrackBar.Minimum = sbyte.MinValue;
				TemperatureTrackBar.Value = sbyte.MinValue;
				TemperatureTrackBar.Maximum = sbyte.MaxValue;
			}
			TemperatureTrackBar.Value = 25;
			TemperatureTrackBar.Maximum = sbyte.MaxValue;
			TemperatureTrackBar.Minimum = sbyte.MinValue;
			TemperatureTrackBar.Scroll += TemperatureTrackBar_ValueChanged;
			TemperatureTrackBar_ValueChanged(TemperatureTrackBar, null);

			AccelerometerRegister = new WritableRegister<Vector3Data>(accelId, 0f);

			initTrackBar(trackBarX);
			initTrackBar(trackBarY);
			initTrackBar(trackBarZ);
			trackBarX.Scroll += AccelTrackBarX_ValueChanged;
			trackBarY.Scroll += AccelTrackBarY_ValueChanged;
			trackBarZ.Scroll += AccelTrackBarZ_ValueChanged;

			AccelTrackBarX_ValueChanged(trackBarX, null);
			AccelTrackBarY_ValueChanged(trackBarY, null);
			AccelTrackBarZ_ValueChanged(trackBarZ, null);
		}

		private void initTrackBar(TrackBar bar) {
			bar.Maximum = int.MaxValue;
			bar.Minimum = int.MinValue;
			bar.Value = 0;
			bar.Maximum = 20 * 5;
			bar.Minimum = -20 * 5;
		}

		private void TemperatureTrackBar_ValueChanged(object sender, EventArgs e) {
			sbyte value = (sbyte)((TrackBar)sender).Value;
			TemperatureRegister.Data = new Int8Data(value);
			tempFeedbackLabel.Text = "Temperature: " + value.ToString().PadLeft(4) + "°C";
		}

		private void accelScroll(TrackBar bar, ref float val) {
			val = bar.Value / 5f;
			AccelerometerRegister.Data = new Vector3Data(accelX, accelY, accelZ);
		}

		private void AccelTrackBarX_ValueChanged(object sender, EventArgs e) {
			accelScroll((TrackBar)sender, ref accelX);
		}

		private void AccelTrackBarY_ValueChanged(object sender, EventArgs e) {
			accelScroll((TrackBar)sender, ref accelY);
		}

		private void AccelTrackBarZ_ValueChanged(object sender, EventArgs e) {
			accelScroll((TrackBar)sender, ref accelZ);
		}

		public override void Update() {
			
		}
	}
}
