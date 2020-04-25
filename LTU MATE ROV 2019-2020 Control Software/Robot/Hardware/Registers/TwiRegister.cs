using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.Registers {
	public class TwiRegister : IDevice {

		public override IRegister[] Registers => new IRegister[] {
			FreqRegister
		};

		private WritableRegister<UInt32Data> FreqRegister;
		public uint Frequency { set => FreqRegister.Data = new UInt32Data(value); }

		public TwiRegister(byte FreqId, float refreshRate = 25f) {
			FreqRegister = new WritableRegister<UInt32Data>(FreqId, refreshRate);
		}

	}
}
