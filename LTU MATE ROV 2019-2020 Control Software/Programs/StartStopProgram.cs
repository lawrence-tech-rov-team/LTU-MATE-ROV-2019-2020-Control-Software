using Emgu.CV;
using LTU_MATE_ROV_2019_2020_Control_Software.Cameras;
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
		private CameraThread cameraThread;

		public StartStopProgram(CameraThread Cameras) : base() {
			cameraThread = Cameras;
		}

		protected override void Initialize() {

		}

		protected override bool Loop() {
			Twist twist = new Twist();
			twist.Linear.X = 1f;
			Input = twist;
			Mat cam1 = cameraThread.Image1;
			if (cam1 != null) Console.WriteLine("Camera 1: {0} x {1}", cam1.Width, cam1.Height);
			if (!Sleep(1000)) return false;

			twist.Linear.X = 0f;
			Input = twist;
			Mat cam2 = cameraThread.Image2;
			if (cam2 != null) Console.WriteLine("Camera 2: {0} x {1}", cam2.Width, cam2.Height);
			return Sleep(1000);
		}

		protected override void Cleanup() {
			Input = new Twist();
		}
	}
}
