using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware;
using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Simulator.Sensors {
	public class DigitalSensorSimulator : ISimulatorDevice {
		public override IRegister[] Registers => new IRegister[]{
			ioRegister
		};

		private WritableRegister<BoolData> ioRegister;

		public DigitalSensorSimulator(byte id, Button button) {
			ioRegister = new WritableRegister<BoolData>(id, 0f);
			button.MouseDown += Button_MouseDown;
			button.MouseUp += Button_MouseUp;
			Button_MouseUp(null, null);
		}

		private void Button_MouseUp(object sender, MouseEventArgs e) {
			ioRegister.Data = new BoolData(false);
		}

		private void Button_MouseDown(object sender, MouseEventArgs e) {
			ioRegister.Data = new BoolData(true);
		}

		public override void Update() {
			
		}
	}
}
