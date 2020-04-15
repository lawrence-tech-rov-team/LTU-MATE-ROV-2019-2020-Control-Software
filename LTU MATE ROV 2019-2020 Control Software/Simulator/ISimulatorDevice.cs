using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Simulator {
	public abstract class ISimulatorDevice : IDevice {

		public abstract void Update();

	}
}
