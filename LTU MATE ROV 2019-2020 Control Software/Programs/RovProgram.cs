using LTU_MATE_ROV_2019_2020_Control_Software.InputControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Programs {
	public abstract class RovProgram : InputProgram {

		//public abstract string Name { get; }
		protected ROV rov;

		protected RovProgram(ROV robot) {
			rov = robot;
		}

		public static InputProgram[] GetPrograms(ROV rov) {
			return new InputProgram[] {
				new StartStopProgram(rov)
			};
		}

	}
}
