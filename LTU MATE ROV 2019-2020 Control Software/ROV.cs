using LTU_MATE_ROV_2019_2020_Control_Software.Hardware;
using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.Actuators;
using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.Ethernet;
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
		public IMU IMU { get; } = new IMU(
			//Register			Id		Refresh Rate
			/*Temperature*/		1,		0.5f,
			/*Accelerometer*/	2,		50f
		);
		public DigitalActuator Led { get; } = new DigitalActuator(3, 50);
		public PressureSensor PressureSensor { get; } = new PressureSensor(4, 10);
		public Servo ServoA1 { get; } = new Servo(
			//Register			Id		Refresh Rate
			/*Position*/		5,
			/*Enable*/			6
		);

		public ROV(ThreadPriority priority, IEthernetLayer ether) : base(priority, ether) {
			RegisterDevice(TestButton);
			RegisterDevice(IMU);
			//	RegisterDevice(Led);
			RegisterDevice(PressureSensor);
			RegisterDevice(ServoA1);
		}

	}
}
