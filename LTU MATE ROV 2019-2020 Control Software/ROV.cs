using LTU_MATE_ROV_2019_2020_Control_Software.Hardware;
using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.Sensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software {
	public class ROV : Robot {

		protected override int BufferSize => 258;
		protected override int TimeoutAttempts => 2; 
		protected override int MessageTimemout => 500;

		//public IMU IMU { get; } = new IMU(0);
		public DigitalSensor TestButton { get; } = new DigitalSensor(0, 100);

		public ROV(ThreadPriority priority) : base(priority) {
			//RegisterDevice(IMU);
			RegisterDevice(TestButton);
		}

	}
}
