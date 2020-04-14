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
	public class CameraThread {

		//private ImageViewer viewer;
		private VideoCapture capture;
		private Thread thread;

		private volatile Mat image;
		public Mat Image { get => image; }

		private volatile bool running = true;

		public CameraThread(ThreadPriority priority) {
			thread = ThreadHelper.StartNewThread("Camera Input Thread", true, ThreadLoop, priority);
		}

		private void ThreadLoop() {
			//viewer = new ImageViewer();
			capture = new VideoCapture();
			//viewer.Show();
			while (running) {
				if (capture.IsOpened) {
					//viewer.Image = capture.QueryFrame();
					image = capture.QueryFrame();
				} else {
					image = null;
				}
				Thread.Sleep(1);
			}
		}
		
		public void StopAsync() {
			running = false;
		}

		public void Stop() {
			try {
				StopAsync();
				thread.Join();
			} catch (Exception) { }
		}

	}
}
