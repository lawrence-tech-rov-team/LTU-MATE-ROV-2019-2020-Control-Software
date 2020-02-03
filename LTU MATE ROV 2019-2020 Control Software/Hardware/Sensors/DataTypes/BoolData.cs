using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware.Sensors.DataTypes {
	public class BoolData {

		public bool Value { get; private set; }

		public BoolData(bool value) {
			Value = value;
		}

	}
}
