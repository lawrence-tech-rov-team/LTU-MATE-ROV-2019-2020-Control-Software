using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LTU_MATE_ROV_2019_2020_Control_Software.Hardware;
using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.DataTypes;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Simulator.Sensors {
	public class PressureSensorSimulator : ISimulatorDevice {

		private const int atmPressure = 1013;
		private const int pressureRange = 500;

		public override IRegister[] Registers => new IRegister[] {
			SensorRegister
		};

		private WritableRegister<FloatData, FloatData> SensorRegister;
		private float temp;
		private float pressure;

		public PressureSensorSimulator(byte id, TrackBar temp, TrackBar pres) {
			SensorRegister = new WritableRegister<FloatData, FloatData>(id, 0f);
			initTrackBar(temp, 10*5, 30*5, 25*5);
			initTrackBar(pres, atmPressure * 5, (atmPressure + pressureRange) * 5, atmPressure * 5);
			temp.Scroll += Temp_Scroll;
			pres.Scroll += Pres_Scroll;
			Temp_Scroll(temp, null);
			Pres_Scroll(pres, null);
		}

		private void initTrackBar(TrackBar bar, int min, int max, int val) {
			bar.Maximum = int.MaxValue;
			bar.Minimum = int.MinValue;
			bar.Value = val;
			bar.Maximum = max;
			bar.Minimum = min;
		}

		private void Pres_Scroll(object sender, EventArgs e) {
			pressure = ((TrackBar)sender).Value / 5f;
			SensorRegister.SetValues(new FloatData(pressure), new FloatData(temp));
			//SensorRegister.Value1 = new FloatData(pressure);
			//SensorRegister.Value2 = new FloatData(temp);
		}

		private void Temp_Scroll(object sender, EventArgs e) {
			temp = ((TrackBar)sender).Value / 5f;
			SensorRegister.SetValues(new FloatData(pressure), new FloatData(temp));
			//SensorRegister.Value1 = new FloatData(pressure);
			//SensorRegister.Value2 = new FloatData(temp);
		}

		public override void Update() {
			
		}
	}
}
