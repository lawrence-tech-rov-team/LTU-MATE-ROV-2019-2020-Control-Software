using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.InputControls {
	public interface IController {

		float ForwardPower { get; }
		float SidePower { get; }

		bool Connect();

		void Disconnect();

		void Update();

	}
}
