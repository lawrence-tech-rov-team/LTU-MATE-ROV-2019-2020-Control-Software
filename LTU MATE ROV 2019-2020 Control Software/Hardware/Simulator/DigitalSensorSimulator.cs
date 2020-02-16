using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware.Simulator {
	public class DigitalSensorSimulator : IWritableDevice<BoolData> {

		public DigitalSensorSimulator(byte id, Button button) : base(id, 0) {
			button.MouseDown += Button_MouseDown;
			button.MouseUp += Button_MouseUp;
			base.Data1 = new BoolData(false);
		}

		private void Button_MouseUp(object sender, MouseEventArgs e) {
			base.Data1 = new BoolData(false);
		}

		private void Button_MouseDown(object sender, MouseEventArgs e) {
			base.Data1 = new BoolData(true);
		}
	}
}
