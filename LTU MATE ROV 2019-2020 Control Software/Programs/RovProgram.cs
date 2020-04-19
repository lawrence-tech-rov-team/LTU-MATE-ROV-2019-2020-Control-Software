using LTU_MATE_ROV_2019_2020_Control_Software.Cameras;
using LTU_MATE_ROV_2019_2020_Control_Software.InputControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Programs {
	public abstract class RovProgram : InputProgram {

		protected RovProgram() {
		
		}

		public static InputProgram[] GetPrograms(CameraThread Cameras) {
			return new InputProgram[] {
				new StartStopProgram(Cameras)
			};
		}

	}
}
