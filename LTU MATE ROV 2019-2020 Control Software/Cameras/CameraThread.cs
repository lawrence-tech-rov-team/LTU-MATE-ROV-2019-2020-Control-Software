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
using Ozeki.Camera;
using Ozeki.Media;
using utils;
using System.Drawing;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Cameras {
	public class CameraThread : ThreadedProcess {

		private VideoCapture capture1;
		//private VideoCapture capture2;
		private OzekiCamera camera;
		private MediaConnector connector = new MediaConnector();
		private SnapshotHandler snapshotHandler = new SnapshotHandler();

		private volatile Mat image1;
		public Mat Image1 { get => image1; }

		private volatile Mat image2;
		public Mat Image2 { get => image2; }

		public CameraThread(ThreadPriority Priority = ThreadPriority.Normal) : base("Camera Input Thread", Priority) {
		}

		protected override void Initialize() {
			capture1 = new VideoCapture(0);
			//capture2 = new VideoCapture("rtsp://admin:admin123@192.168.0.108:554:network-caching=500");
			//capture2 = new VideoCapture("http://192.168.0.108/cam/realmonitor?channel=1&subtype=0&unicast=true&proto=Onvif");
			//capture2 = new VideoCapture("rtsp://admin:admin123@192.168.0.108:554/"); 
			camera = new OzekiCamera("http://192.168.0.108:80;Username=admin;Password=admin123;Transport=UDP;");
			connector.Connect(camera.VideoChannel, snapshotHandler);
			camera.Start();
		}

		protected override bool Loop() {
			if (capture1.IsOpened) {
				image1 = capture1.QueryFrame();
			} else {
				image1 = null;
			}

			/*if (capture2.IsOpened) {
				image2 = capture2.QueryFrame();
			} else {
				image2 = null;
			}*/
			//		if (camera.Capturing) {
			var snapshotRaw = snapshotHandler.TakeSnapshot();
			if (snapshotRaw != null) {
				Bitmap snapshot = (Bitmap)snapshotRaw.ToImage();
				Image<Bgr, byte> imageCV = new Image<Bgr, byte>(snapshot);
				image2 = imageCV.Mat;
				snapshot.Dispose();
			} else {
				image2 = null;
			}
				//snapshot.Save("", System.Drawing.Imaging.ImageFormat.Jpeg);
	//		} else {
	//			image2 = null;
	//		}

			return true;
		}

		protected override void Cleanup() {
			try {
				capture1?.Dispose();
			} catch (Exception) { }

			try {
				//capture2?.Dispose();
				camera.Disconnect();
				camera.Dispose();
			} catch (Exception) { }
		}


	}
}
