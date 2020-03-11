using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware.Sensors {
	public class PressureSensor : IDevice {

		public override IRegister[] Registers => new IRegister[] {
			SensorRegister
		};

		private ReadableRegister<FloatData, FloatData> SensorRegister;
		public float Pressure => SensorRegister.Value1?.Value ?? default(float);
		public float Temperature => SensorRegister.Value2?.Value ?? default(float);

		public PressureSensor(byte sensorId, float refreshRate) {
			SensorRegister = new ReadableRegister<FloatData, FloatData>(sensorId, refreshRate);
		}

	}
}
