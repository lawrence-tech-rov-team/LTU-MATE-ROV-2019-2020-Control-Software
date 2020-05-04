using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.DataTypes;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.Actuators {
	public class PWM : IDevice {

		public override IRegister[] Registers => new IRegister[] {
			PositionRegister,
			EnableRegister
		};

		private WritableRegister<UInt16Data> PositionRegister;
		private WritableRegister<BoolData> EnableRegister;

		public ushort Pulse { set => PositionRegister.Data = new UInt16Data(value); }
		public bool Enabled { set => EnableRegister.Data = new BoolData(value); }

		public PWM(byte posId, byte enableId, float refreshRate = 25f) {
			PositionRegister = new WritableRegister<UInt16Data>(posId, refreshRate);
			EnableRegister = new WritableRegister<BoolData>(enableId, refreshRate);
		}

	}
}
