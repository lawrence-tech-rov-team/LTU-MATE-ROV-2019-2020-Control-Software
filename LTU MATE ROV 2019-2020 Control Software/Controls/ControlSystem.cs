using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Controls {
	public class ControlSystem {

		private Timer timer;

		public ControlSystem(double millisFrequency) {
			timer = new Timer();
			timer.Interval = millisFrequency;
			timer.Elapsed += Timer_Elapsed;
			timer.Start();
		}

		public void Start() {
			timer.Start();
		}

		public void Stop() {
			timer.Stop();
		}

		private void Timer_Elapsed(object sender, ElapsedEventArgs e) {
			throw new NotImplementedException();
		}
	}
}
