using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTU_MATE_ROV_2019_2020_Control_Software.Hardware;
using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.DataTypes;
using Meters;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Simulator.Actuators {
	public class ServoSimulator : ISimulatorDevice {

		private const ushort MinimumValue = 500;
		private const ushort MaximumValue = 2500;

		private LinearMeter meter;
		private Color originalBgColor;
		private Color originalMeterColor;
		private Color dimmedBgColor;
		private Color dimmedMeterColor;

		public override IRegister[] Registers => new IRegister[] {
			PositionRegister,
			EnableRegister
		};

		private ReadableRegister<UInt16Data> PositionRegister;
		private ReadableRegister<BoolData> EnableRegister;

		public override void Update() {
			if(!(EnableRegister.Data?.Value ?? false)) {
				meter.BackColor = dimmedBgColor;
				meter.MeterColor = dimmedMeterColor;
			} else {
				meter.BackColor = originalBgColor;
				meter.MeterColor = originalMeterColor;

				ushort value = PositionRegister.Data?.Value ?? 1500;
				if (value < MinimumValue) value = MinimumValue;
				if (value > MaximumValue) value = MaximumValue;
				meter.Value = value;
			}
		}

		public ServoSimulator(byte posId, byte enableId, LinearMeter meter) {
			PositionRegister = new ReadableRegister<UInt16Data>(posId, 0f);
			EnableRegister = new ReadableRegister<BoolData>(enableId, 0f);
			this.meter = meter;

			originalBgColor = meter.BackColor;
			originalMeterColor = meter.MeterColor;
			dimmedBgColor = Color.FromArgb(
				originalBgColor.A / 2,
				originalBgColor.R / 2,
				originalBgColor.G / 2,
				originalBgColor.B / 2
			);
			dimmedMeterColor = Color.FromArgb(
				originalMeterColor.A / 2,
				originalMeterColor.R / 2,
				originalMeterColor.G / 2,
				originalMeterColor.B / 2
			);

			if(meter.Maximum < ushort.MaxValue) {
				meter.Maximum = ushort.MaxValue;
				meter.Value = ushort.MaxValue;
				meter.Minimum = ushort.MinValue;
			} else {
				meter.Minimum = ushort.MinValue;
				meter.Value = meter.Minimum;
				meter.Maximum = ushort.MaxValue;
			}

			meter.Value = (MaximumValue - MinimumValue) / 2 + MinimumValue;
			meter.Maximum = MaximumValue;
			meter.Minimum = MinimumValue;

			Update();
		}
	}
}
