using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LTU_MATE_ROV_2019_2020_Control_Software.Hardware;
using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.DataTypes;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Simulator.Sensors {
	public class ImuSimulator : ISimulatorDevice {
		public override IRegister[] Registers => new IRegister[] {
			TemperatureRegister
		};

		private Label tempFeedbackLabel;
		private WritableRegister<Int8Data> TemperatureRegister;

		public ImuSimulator(byte TemperatureId, TrackBar TemperatureTrackBar, Label TemperatureFeedbackLabel) {
			TemperatureRegister = new WritableRegister<Int8Data>(TemperatureId, 0f);
			this.tempFeedbackLabel = TemperatureFeedbackLabel;
			TemperatureTrackBar.Maximum = int.MaxValue;
			TemperatureTrackBar.Value = 25;
			TemperatureTrackBar.Minimum = sbyte.MinValue;
			TemperatureTrackBar.Maximum = sbyte.MaxValue;
			TemperatureTrackBar_ValueChanged(TemperatureTrackBar, null);
			TemperatureTrackBar.Scroll += TemperatureTrackBar_ValueChanged;
		}

		private void TemperatureTrackBar_ValueChanged(object sender, EventArgs e) {
			sbyte value = (sbyte)((TrackBar)sender).Value;
			TemperatureRegister.Value = new Int8Data(value);
			tempFeedbackLabel.Text = "Temperature: " + value.ToString().PadLeft(4) + "°C";
		}

		public override void Update() {
			
		}
	}
}
