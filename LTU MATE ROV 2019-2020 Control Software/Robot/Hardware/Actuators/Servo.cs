using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.DataTypes;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
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

		public ushort Pulse { set => PositionRegister.Data = new UInt16Data(PulseRange.Limit(value)); }
		public bool Enabled { set => EnableRegister.Data = new BoolData(value); }

		public Range PulseRange = new Range(0, 3000);
		public ushort MinimumPulse { get => PulseRange.Minimum; set => PulseRange.Minimum = value; }
		public ushort MaximumPulse { get => PulseRange.Maximum; set => PulseRange.Maximum = value; }
		public float Position { set => Pulse = PulseRange.Interpolate(value); }

		public Servo(byte posId, byte enableId, float refreshRate = 25f) {
			PositionRegister = new WritableRegister<UInt16Data>(posId, refreshRate);
			EnableRegister = new WritableRegister<BoolData>(enableId, refreshRate);
		}

	}
}
