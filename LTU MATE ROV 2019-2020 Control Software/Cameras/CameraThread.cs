using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System.Threading;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Cameras {
	public class CameraThread : ThreadedProcess {

		//private ImageViewer viewer;
		private VideoCapture capture;

		private volatile Mat image;
		public Mat Image { get => image; }

		public CameraThread(ThreadPriority Priority = ThreadPriority.Normal) : base("Camera Input Thread", Priority) {
		}

		protected override void Initialize() {
			capture = new VideoCapture();
		}

		protected override bool Loop() {
			if (capture.IsOpened) {
				image = capture.QueryFrame();
			} else {
				image = null;
			}
			return Sleep(1);
		}

		protected override void Cleanup() {
			
		}


	}
}
