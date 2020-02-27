using LTU_MATE_ROV_2019_2020_Control_Software.Hardware;
using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.DataTypes;
using Meters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Simulator.Actuators {
	public class DigitalActuatorSimulator : ISimulatorDevice {

		public override IRegister[] Registers => new IRegister[] {
			ioRegister
		};

		private ReadableRegister<BoolData> ioRegister;
		private bool Enabled {
			get => ioRegister.Value?.Value ?? default(bool);
		}

		private IOMeter Indicator;

		public DigitalActuatorSimulator(byte id, IOMeter indicator) {
			this.Indicator = indicator;
			ioRegister = new ReadableRegister<BoolData>(id, 0f);
		}

		public override void Update() {
			Indicator.Value = Enabled;
		}
	}
}
