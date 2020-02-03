using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.Sensors.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware.Sensors {
	public class DigitalSensor : ISensor<BoolData> {
		public override SensorType Type => SensorType.Digital;
		public bool Inversed { get; private set; }

		public DigitalSensor(byte id, bool inversed = false, float RefreshRate = 50f) : base(id, RefreshRate) {
			Inversed = inversed;
		}

		protected override BoolData ParseData(byte[] data) {
			if(data.Length == 2) {
				return new BoolData((data[1] > 0) ^ Inversed);
			} else {
				return null;
			}
		}
	}
}
