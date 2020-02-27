using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware.Simulator {
	public class DigitalSensorSimulator : ISimulatorDevice {
		public override IRegister[] Registers => throw new NotImplementedException();

		private WritableRegister<BoolData> ioRegister;

		public DigitalSensorSimulator(byte id, Button button) {
			ioRegister = new WritableRegister<BoolData>(id, 0f);
			ioRegister.Value = new BoolData(false);
			button.MouseDown += Button_MouseDown;
			button.MouseUp += Button_MouseUp;
		}

		private void Button_MouseUp(object sender, MouseEventArgs e) {
			ioRegister.Value = new BoolData(false);
		}

		private void Button_MouseDown(object sender, MouseEventArgs e) {
			ioRegister.Value = new BoolData(true);
		}

		public override void Update() {
			
		}
	}
}
