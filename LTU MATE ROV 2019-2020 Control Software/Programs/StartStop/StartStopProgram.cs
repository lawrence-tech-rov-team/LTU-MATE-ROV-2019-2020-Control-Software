using Emgu.CV;
using LTU_MATE_ROV_2019_2020_Control_Software.Cameras;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Programs.StartStop {
	public class StartStopProgram : RovProgram {

		public ThreadMethodLinker StartButtonClicked { get; }
		public ThreadMethodLinker StopButtonClicked { get; }

		public override string Name => "Start Stop";
		private CameraThread cameraThread;

		public StartStopProgram(CameraThread Cameras) : base() {
			cameraThread = Cameras;
			StartButtonClicked = new ThreadMethodLinker(OnStartButtonClicked);
			StopButtonClicked = new ThreadMethodLinker(OnStopButtonClicked);

		}

		protected override void Setup() {
			Input = new Twist(); //Initialize to stopped
			AddEventListener(StartButtonClicked);
			AddEventListener(StopButtonClicked);
		}

		protected override bool Run() {
			/*Twist twist = new Twist();
			twist.Linear.X = 1f;
			Input = twist;
			Mat cam1 = cameraThread.Image1;
			if (cam1 != null) Console.WriteLine("Camera 1: {0} x {1}", cam1.Width, cam1.Height);
			if (!Sleep(1000)) return false;

			twist.Linear.X = 0f;
			Input = twist;
			Mat cam2 = cameraThread.Image2;
			if (cam2 != null) Console.WriteLine("Camera 2: {0} x {1}", cam2.Width, cam2.Height);
			return Sleep(1000);*/

			//ProcessEvents(); //Required to receive button clicks

			return true; //Loop forever, the events are handling all input changes
		}

		protected override void Finish() {
			Input = new Twist(); //Finish by stopping the rov
		}

		private void OnStartButtonClicked() {
			Twist twist = new Twist();
			twist.Linear.X = 1f;
			Input = twist;
		}

		private void OnStopButtonClicked() {
			Input = new Twist();
		}

		protected override Form CreateGUI() {
			return new StartStopGui(this);
		}
	}
}
