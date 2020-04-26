using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware;
using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.Actuators;
using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.Ethernet;
using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.Registers;
using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.Sensors;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Robot {
	public class ROV : Hardware.Robot {

		private const float ServoRefreshRate = 20f;

		protected override int BufferSize => 258;
		protected override int TimeoutAttempts => 2; 
		protected override int MessageTimemout => 500;

		public Servo ServoA1 { get; } = new Servo(0, 1, ServoRefreshRate);
		public Servo ServoA2 { get; } = new Servo(2, 3, ServoRefreshRate);
		public Servo ServoA3 { get; } = new Servo(4, 5, ServoRefreshRate);
		public Servo ServoA4 { get; } = new Servo(6, 7, ServoRefreshRate);
		public Servo ServoA5 { get; } = new Servo(8, 9, ServoRefreshRate);

		public Servo ServoB1 { get; } = new Servo(10, 11, ServoRefreshRate);
		public Servo ServoB2 { get; } = new Servo(12, 13, ServoRefreshRate);
		public Servo ServoB3 { get; } = new Servo(14, 15, ServoRefreshRate);
		public Servo ServoB4 { get; } = new Servo(16, 17, ServoRefreshRate);
		public Servo ServoB5 { get; } = new Servo(18, 19, ServoRefreshRate);
		public Servo ServoB6 { get; } = new Servo(20, 21, ServoRefreshRate);

		public Servo ServoC1 { get; } = new Servo(22, 23, ServoRefreshRate);
		public Servo ServoC2 { get; } = new Servo(24, 25, ServoRefreshRate);
		public Servo ServoC3 { get; } = new Servo(26, 27, ServoRefreshRate);
		public Servo ServoC4 { get; } = new Servo(28, 29, ServoRefreshRate);
		public Servo ServoC5 { get; } = new Servo(30, 31, ServoRefreshRate);
		public Servo ServoC6 { get; } = new Servo(32, 33, ServoRefreshRate);
		public Servo ServoC7 { get; } = new Servo(34, 35, ServoRefreshRate);
		public Servo ServoC8 { get; } = new Servo(36, 37, ServoRefreshRate);

		public Servo ServoD1 { get; } = new Servo(38, 39, ServoRefreshRate);
		public Servo ServoD2 { get; } = new Servo(40, 41, ServoRefreshRate);
		public Servo ServoD3 { get; } = new Servo(42, 43, ServoRefreshRate);
		public Servo ServoD4 { get; } = new Servo(44, 45, ServoRefreshRate);
		public Servo ServoD5 { get; } = new Servo(46, 47, ServoRefreshRate);
		public Servo ServoD6 { get; } = new Servo(48, 49, ServoRefreshRate);
		public Servo ServoD7 { get; } = new Servo(50, 51, ServoRefreshRate);
		public Servo ServoD8 { get; } = new Servo(52, 53, ServoRefreshRate);

		public DigitalSensor Button0 { get; } = new DigitalSensor(54, 10f);
		public DigitalSensor Button1 { get; } = new DigitalSensor(55, 10f);
		public DigitalActuator Led { get; } = new DigitalActuator(56, 10f);
		public PressureSensor PressureSensor { get; } = new PressureSensor(57, 10f);
		public IMU IMU { get; } = new IMU(
			//Register			Id		Refresh Rate
			/*Temperature*/		58,		0.5f,
			/*Accelerometer*/	59,		50f,
			/*Magnometer*/		60,		10f,
			/*Gyroscope*/		61,		50f,
			/*Euler*/			62,		50f,
			/*Linear Accel*/	63,		50f,
			/*Gravity*/			64,		50f,
			/*Quaternion*/		65,		50f
		);

		public TwiRegister TwiSettings { get; } = new TwiRegister(66, 10f);

		public Dictionary<char, Servo[]> Servos;

		public ROV(IEthernetLayer ether) : base(ether) {
			Servos = new Dictionary<char, Servo[]> () {
				{ 'A', new Servo[] { ServoA1, ServoA2, ServoA3, ServoA4, ServoA5 } },
				{ 'B', new Servo[] { ServoB1, ServoB2, ServoB3, ServoB4, ServoB5, ServoB6 } },
				{ 'C', new Servo[] { ServoC1, ServoC2, ServoC3, ServoC4, ServoC5, ServoC6, ServoC7, ServoC8 } },
				{ 'D', new Servo[] { ServoD1, ServoD2, ServoD3, ServoD4, ServoD5, ServoD6, ServoD7, ServoD8 } }
			};

			RegisterDevice(Button0);
			RegisterDevice(Button1);
			RegisterDevice(Led);
			RegisterDevice(PressureSensor);
			RegisterDevice(IMU);
			foreach(Servo[] servos in Servos.Values) {
				foreach(Servo servo in servos) {
					RegisterDevice(servo);
				}
			}
			RegisterDevice(TwiSettings);
		}

	}
}
