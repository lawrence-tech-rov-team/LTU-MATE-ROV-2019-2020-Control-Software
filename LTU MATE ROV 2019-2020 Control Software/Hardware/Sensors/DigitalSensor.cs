using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.DataTypes;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware.Sensors {
	public class DigitalSensor : ISensor<BoolData> {

		public bool State {
			get {
				bool state = Data1?.Value ?? default(bool);
				return state ^ Inversed;
			}
		}
		public bool Inversed { get; private set; }

		public DigitalSensor(byte id, float RefreshRate = 50f, bool inversed = false) : base(id, RefreshRate) {
			Inversed = inversed;
		}
	}
}
