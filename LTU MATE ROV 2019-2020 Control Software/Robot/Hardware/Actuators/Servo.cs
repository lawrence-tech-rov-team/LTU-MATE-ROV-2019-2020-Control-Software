using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.Actuators {
	public class Servo : IDevice {

		public override IRegister[] Registers => new IRegister[] {
			PositionRegister,
			EnableRegister
		};

		private WritableRegister<UInt16Data> PositionRegister;
		private WritableRegister<BoolData> EnableRegister;

		public ushort Pulse { set => PositionRegister.Data = new UInt16Data(value); }
		public bool Enable { set => EnableRegister.Data = new BoolData(value); }
		/*
		public void SetPosition(float pos) {
			if (pos < -1f) pos = -1f;
			if (pos > 1f) pos = 1f;
			int v = (int)(((pos + 1f) / 2f) * 255f);
			if (v < 0) v = 0;
			if (v > 255) v = 255;
			PositionRegister.Value = new UInt8Data((byte)v);
		}
		*/

		public Servo(byte posId, byte enableId, float refreshRate = 25f) {
			PositionRegister = new WritableRegister<UInt16Data>(posId, refreshRate);
			EnableRegister = new WritableRegister<BoolData>(enableId, refreshRate);
		}

	}
}
