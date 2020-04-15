using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.Actuators {
	public class DigitalActuator : IDevice {

		public override IRegister[] Registers => new IRegister[] {
			ioRegister
		};

		private WritableRegister<BoolData> ioRegister;

		public bool Enabled {
			set {
				ioRegister.Data = new BoolData(value);
			}
		}

		public DigitalActuator(byte id, float refreshRate = 50f) {
			ioRegister = new WritableRegister<BoolData>(id, refreshRate);
		}
	}
}
