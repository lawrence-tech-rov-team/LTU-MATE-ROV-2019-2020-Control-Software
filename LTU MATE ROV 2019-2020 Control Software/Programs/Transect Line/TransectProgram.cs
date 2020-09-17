using Emgu.CV;
using LTU_MATE_ROV_2019_2020_Control_Software.Cameras;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Transect_Line_Code;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Programs.Transect_Line {
	public class TransectProgram : RovProgram {

		public override string Name => "Transect Line";
		private CameraThread cameraThread;
		private Form1 form;

		public TransectProgram(CameraThread Cameras) : base() {
			cameraThread = Cameras;
		}

		protected override void Setup() {
			form = new Form1(SleepMillis, SetInput, ReadCamera1, ReadCamera2);
		}

		protected override bool Run() {
			form.ShowDialog();
			return false;
		}

		protected override void Finish() {
			form.Dispose();
		}

		private void SetInput(Twist value) {
			Input = value;
		}

		private Mat ReadCamera1() {
			return cameraThread.Image1;
		}

		private Mat ReadCamera2() {
			return cameraThread.Image2;
		}

		private bool SleepMillis(long millis) {
			return Sleep(millis);
		}

	}
}
