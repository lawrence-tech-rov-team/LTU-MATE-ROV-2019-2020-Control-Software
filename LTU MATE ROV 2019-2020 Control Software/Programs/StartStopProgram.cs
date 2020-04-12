using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Programs {
	public class StartStopProgram : RovProgram {

		public override string Name => "Start Stop";

		public StartStopProgram() : base() {
		}

		public override void Initialize() {

		}

		public override bool Loop() {
			Twist twist = new Twist();
			twist.Linear.X = 1f;
			Input = twist;
			if (!Sleep(1000)) return false;
			twist.Linear.X = 0f;
			Input = twist;
			return Sleep(1000);
		}

		public override void Cleanup() {
			Input = new Twist();
		}
	}
}
