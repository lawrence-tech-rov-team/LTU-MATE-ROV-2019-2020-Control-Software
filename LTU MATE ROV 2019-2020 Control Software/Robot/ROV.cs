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

		private const float PwmRefreshRate = 20f;

		protected override int BufferSize => 258;
		protected override int TimeoutAttempts => 2; 
		protected override int MessageTimemout => 500;

		public Servo LeftGripperServo { get; }
		public Servo RightGripperServo { get; }
		public Servo NetServo { get; }

		public PWM PwmA1 { get; } = new PWM(0, 1, PwmRefreshRate);
		public PWM PwmA2 { get; } = new PWM(2, 3, PwmRefreshRate);
		public PWM PwmA3 { get; } = new PWM(4, 5, PwmRefreshRate);
		public PWM PwmA4 { get; } = new PWM(6, 7, PwmRefreshRate);
		public PWM PwmA5 { get; } = new PWM(8, 9, PwmRefreshRate);

		public PWM PwmB1 { get; } = new PWM(10, 11, PwmRefreshRate);
		public PWM PwmB2 { get; } = new PWM(12, 13, PwmRefreshRate);
		public PWM PwmB3 { get; } = new PWM(14, 15, PwmRefreshRate);
		public PWM PwmB4 { get; } = new PWM(16, 17, PwmRefreshRate);
		public PWM PwmB5 { get; } = new PWM(18, 19, PwmRefreshRate);
		public PWM PwmB6 { get; } = new PWM(20, 21, PwmRefreshRate);

		public PWM PwmC1 { get; } = new PWM(22, 23, PwmRefreshRate);
		public PWM PwmC2 { get; } = new PWM(24, 25, PwmRefreshRate);
		public PWM PwmC3 { get; } = new PWM(26, 27, PwmRefreshRate);
		public PWM PwmC4 { get; } = new PWM(28, 29, PwmRefreshRate);
		public PWM PwmC5 { get; } = new PWM(30, 31, PwmRefreshRate);
		public PWM PwmC6 { get; } = new PWM(32, 33, PwmRefreshRate);
		public PWM PwmC7 { get; } = new PWM(34, 35, PwmRefreshRate);
		public PWM PwmC8 { get; } = new PWM(36, 37, PwmRefreshRate);

		public PWM PwmD1 { get; } = new PWM(38, 39, PwmRefreshRate);
		public PWM PwmD2 { get; } = new PWM(40, 41, PwmRefreshRate);
		public PWM PwmD3 { get; } = new PWM(42, 43, PwmRefreshRate);
		public PWM PwmD4 { get; } = new PWM(44, 45, PwmRefreshRate);
		public PWM PwmD5 { get; } = new PWM(46, 47, PwmRefreshRate);
		public PWM PwmD6 { get; } = new PWM(48, 49, PwmRefreshRate);
		public PWM PwmD7 { get; } = new PWM(50, 51, PwmRefreshRate);
		public PWM PwmD8 { get; } = new PWM(52, 53, PwmRefreshRate);

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

		public IEnumerable<PWM> AllPWM {
			get {
				IEnumerable<PWM> list = null;
				foreach (PWM[] pwm in PWM.Values) {
					if (list == null) list = pwm.AsEnumerable();
					else list.Concat(pwm.AsEnumerable());
				}
				return list ?? new List<PWM>().AsEnumerable();
			}
		}
		public Dictionary<char, PWM[]> PWM;

		public ROV(IEthernetLayer ether) : base(ether) {
			PWM = new Dictionary<char, PWM[]> () {
				{ 'A', new PWM[] { PwmA1, PwmA2, PwmA3, PwmA4, PwmA5 } },
				{ 'B', new PWM[] { PwmB1, PwmB2, PwmB3, PwmB4, PwmB5, PwmB6 } },
				{ 'C', new PWM[] { PwmC1, PwmC2, PwmC3, PwmC4, PwmC5, PwmC6, PwmC7, PwmC8 } },
				{ 'D', new PWM[] { PwmD1, PwmD2, PwmD3, PwmD4, PwmD5, PwmD6, PwmD7, PwmD8 } }
			};

			LeftGripperServo = new Servo(PwmA2, 0, 270);
			RightGripperServo = new Servo(PwmA3, 0, 270);
			NetServo = new Servo(PwmA4, 0, 270);
		}

		protected override void RegisterAllDevices() {
			RegisterDevice(Button0);
			RegisterDevice(Button1);
			RegisterDevice(Led);
			RegisterDevice(PressureSensor);
			RegisterDevice(IMU);
			foreach (PWM[] pwms in PWM.Values) {
				foreach (PWM pwm in pwms) {
					RegisterDevice(pwm);
				}
			}
			RegisterDevice(TwiSettings);
		}

	}
}
