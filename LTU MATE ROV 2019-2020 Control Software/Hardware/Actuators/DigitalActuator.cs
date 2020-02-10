using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.Sensors.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware.Actuators {
	public class DigitalActuator : IActuator<BoolData> {

		public bool Enabled {
			set {
				Data1 = new BoolData(value);
			}
		}

		public DigitalActuator(byte id, float refreshRate = 1) : base(id, refreshRate) {
		}
	}
}
