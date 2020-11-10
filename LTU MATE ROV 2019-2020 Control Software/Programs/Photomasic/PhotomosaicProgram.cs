using LTU_MATE_ROV_2019_2020_Control_Software.Cameras;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Programs.Photomasic {
	public class PhotomosaicProgram : RovProgram {
		public override string Name => "Photomosaic";

		private CameraThread cameras;

		public PhotomosaicProgram(CameraThread Cameras) {
			this.cameras = Cameras;
		}

		protected override Form CreateGUI() {
			return base.CreateGUI();
		}

		protected override void Setup() {
			Input = new Utils.Twist();
		}

		protected override bool Run() {
			return true;
		}

		protected override void Finish() {
			Input = new Utils.Twist();
		}
	}
}
