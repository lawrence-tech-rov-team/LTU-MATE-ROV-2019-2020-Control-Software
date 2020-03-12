using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware.Actuators {
	public class Servo : IDevice {

		public override IRegister[] Registers => new IRegister[] {
			PositionRegister,
			MinimumRegister,
			MaximumRegister,
			EnableRegister
		};

		private WritableRegister<UInt8Data> PositionRegister;
		private WritableRegister<UInt16Data> MinimumRegister;
		private WritableRegister<UInt16Data> MaximumRegister;
		private WritableRegister<BoolData> EnableRegister;

		public ushort MinimumPulse { set => MinimumRegister.Value = new UInt16Data(value); }
		public ushort MaximumPulse { set => MaximumRegister.Value = new UInt16Data(value); }
		public bool Enable { set => EnableRegister.Value = new BoolData(value); }

		public void SetPosition(float pos) {
			if (pos < -1f) pos = -1f;
			if (pos > 1f) pos = 1f;
			int v = (int)(((pos + 1f) / 2f) * 255f);
			if (v < 0) v = 0;
			if (v > 255) v = 255;
			PositionRegister.Value = new UInt8Data((byte)v);
		}

		public void SetPosition(byte pos) {
			PositionRegister.Value = new UInt8Data(pos);
		}

		public Servo(byte id, byte minId, byte maxId, byte enableId, float refreshRate = 25f) {
			PositionRegister = new WritableRegister<UInt8Data>(id, refreshRate);
			MinimumRegister = new WritableRegister<UInt16Data>(minId, refreshRate);
			MaximumRegister = new WritableRegister<UInt16Data>(maxId, refreshRate);
			EnableRegister = new WritableRegister<BoolData>(enableId, refreshRate);
		}

	}
}
