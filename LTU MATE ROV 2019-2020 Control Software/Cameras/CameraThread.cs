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

		private VideoCapture capture1;
		private VideoCapture capture2;

		private volatile Mat image1;
		public Mat Image1 { get => image1; }

		private volatile Mat image2;
		public Mat Image2 { get => image2; }

		public CameraThread(ThreadPriority Priority = ThreadPriority.Normal) : base("Camera Input Thread", Priority) {
		}

		protected override void Initialize() {
			capture1 = new VideoCapture(0);
			capture2 = new VideoCapture(1);
		}

		protected override bool Loop() {
			if (capture1.IsOpened) {
				image1 = capture1.QueryFrame();
			} else {
				image1 = null;
			}

			if (capture2.IsOpened) {
				image2 = capture2.QueryFrame();
			} else {
				image2 = null;
			}

			return true;
		}

		protected override void Cleanup() {
			try {
				capture1?.Dispose();
			} catch (Exception) { }

			try {
				capture2?.Dispose();
			} catch (Exception) { }
		}


	}
}
