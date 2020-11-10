using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.Actuators;
using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.Ethernet;
using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.Registers;
using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.Sensors;
using System.Collections.Generic;
using System.Linq;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Robot {
	public class ROV : Hardware.Robot {

		private const float PwmRefreshRate = 20f;

		protected override int BufferSize => 258;
		protected override int TimeoutAttempts => 3;
		protected override int MessageTimemout => 1000;//500;

		public RangedPWM PwmA1 { get; } = new RangedPWM(0, 1, PwmRefreshRate);
		public RangedPWM PwmA2 { get; } = new RangedPWM(2, 3, PwmRefreshRate);
		public RangedPWM PwmA3 { get; } = new RangedPWM(4, 5, PwmRefreshRate);
		public RangedPWM PwmA4 { get; } = new RangedPWM(6, 7, PwmRefreshRate);
		public RangedPWM PwmA5 { get; } = new RangedPWM(8, 9, PwmRefreshRate);

		public RangedPWM PwmB1 { get; } = new RangedPWM(10, 11, PwmRefreshRate);
		public RangedPWM PwmB2 { get; } = new RangedPWM(12, 13, PwmRefreshRate);
		public RangedPWM PwmB3 { get; } = new RangedPWM(14, 15, PwmRefreshRate);
		public RangedPWM PwmB4 { get; } = new RangedPWM(16, 17, PwmRefreshRate);
		public RangedPWM PwmB5 { get; } = new RangedPWM(18, 19, PwmRefreshRate);
		public RangedPWM PwmB6 { get; } = new RangedPWM(20, 21, PwmRefreshRate);

		public RangedPWM PwmC1 { get; } = new RangedPWM(22, 23, PwmRefreshRate);
		public RangedPWM PwmC2 { get; } = new RangedPWM(24, 25, PwmRefreshRate);
		public RangedPWM PwmC3 { get; } = new RangedPWM(26, 27, PwmRefreshRate);
		public RangedPWM PwmC4 { get; } = new RangedPWM(28, 29, PwmRefreshRate);
		public RangedPWM PwmC5 { get; } = new RangedPWM(30, 31, PwmRefreshRate);
		public RangedPWM PwmC6 { get; } = new RangedPWM(32, 33, PwmRefreshRate);
		public RangedPWM PwmC7 { get; } = new RangedPWM(34, 35, PwmRefreshRate);
		public RangedPWM PwmC8 { get; } = new RangedPWM(36, 37, PwmRefreshRate);

		public RangedPWM PwmD1 { get; } = new RangedPWM(38, 39, PwmRefreshRate);
		public RangedPWM PwmD2 { get; } = new RangedPWM(40, 41, PwmRefreshRate);
		public RangedPWM PwmD3 { get; } = new RangedPWM(42, 43, PwmRefreshRate);
		public RangedPWM PwmD4 { get; } = new RangedPWM(44, 45, PwmRefreshRate);
		public RangedPWM PwmD5 { get; } = new RangedPWM(46, 47, PwmRefreshRate);
		public RangedPWM PwmD6 { get; } = new RangedPWM(48, 49, PwmRefreshRate);
		public RangedPWM PwmD7 { get; } = new RangedPWM(50, 51, PwmRefreshRate);
		public RangedPWM PwmD8 { get; } = new RangedPWM(52, 53, PwmRefreshRate);

		public DigitalSensor Button0 { get; } = new DigitalSensor(54, 10f);
		public DigitalSensor Button1 { get; } = new DigitalSensor(55, 10f);
		public DigitalActuator Led { get; } = new DigitalActuator(56, 10f);
		public PressureSensor PressureSensor { get; } = new PressureSensor(57, 10f);
		public IMU IMU { get; } = new IMU(
			//Register			Id		Refresh Rate
			/*Temperature*/		58,		0.5f,
			/*Accelerometer*/	59,		10f, //50f,
			/*Magnometer*/		60,		10f,
			/*Gyroscope*/		61,		10f, //50f,
			/*Euler*/			62,		10f, //50f,
			/*Linear Accel*/    63,		10f, //50f,
			/*Gravity*/         64,		10f, //50f,
			/*Quaternion*/      65,		10f //50f,
		);

		public TwiRegister TwiSettings { get; } = new TwiRegister(66, 10f);

		public Servo FrontLeftServo { get; }
		public Servo FrontRightServo { get; }
		public Servo BackLeftServo { get; }
		public Servo BackRightServo { get; }
		public Servo LeftGripperServo { get; }
		public Servo RightGripperServo { get; }
		public Servo NetServo { get; }
		public Dictionary<string, Servo> Servos { get => new Dictionary<string, Servo> {
			{ "Front Left", FrontLeftServo },
			{ "Front Right", FrontRightServo },
			{ "Back Left", BackLeftServo },
			{ "Back Right", BackRightServo },
			{ "Left Gripper", LeftGripperServo },
			{ "Right Gripper", RightGripperServo },
			{ "Net", NetServo }
		}; }

		public Thruster FrontLeftThruster { get; }
		public Thruster FrontRightThruster { get; }
		public Thruster BackLeftThruster { get; }
		public Thruster BackRightThruster { get; }
		public Thruster MiniRovThruster { get; }
		public Dictionary<string, Thruster> Thrusters {
			get => new Dictionary<string, Thruster> {
			{ "Front Left", FrontLeftThruster },
			{ "Front Right", FrontRightThruster },
			{ "Back Left", BackLeftThruster },
			{ "Back Right", BackRightThruster },
			{ "Mini ROV", MiniRovThruster }
		}; }

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
				{ 'A', new PWM[] { PwmA1/*, PwmA2, PwmA3, PwmA4, PwmA5*/ } }//,
				//{ 'B', new PWM[] { PwmB1, PwmB2, PwmB3, PwmB4, PwmB5, PwmB6 } },
				//{ 'C', new PWM[] { PwmC1, PwmC2, PwmC3, PwmC4, PwmC5, PwmC6, PwmC7, PwmC8 } },
				//{ 'D', new PWM[] { PwmD1, PwmD2, PwmD3, PwmD4, PwmD5, PwmD6, PwmD7, PwmD8 } }
			};

			FrontLeftServo = new Servo(PwmA1, 0, 270);
			FrontRightServo = new Servo(PwmA2, 0, 270);
			BackLeftServo = new Servo(PwmA3, 0, 270);
			BackRightServo = new Servo(PwmA4, 0, 270);
			LeftGripperServo = new Servo(PwmA5, 0, 270);
			RightGripperServo = new Servo(PwmB5, 0, 270);
			NetServo = new Servo(PwmC1, 0, 270);

			FrontLeftThruster = new Thruster(PwmB1, 1180, 1500, 1814);
			FrontRightThruster = new Thruster(PwmB2, 1180, 1500, 1814);
			BackLeftThruster = new Thruster(PwmB3, 1180, 1500, 1814);
			BackRightThruster = new Thruster(PwmB4, 1180, 1500, 1814);
			MiniRovThruster = new Thruster(PwmB6, 1140, 1500, 1855);
		}

		protected override void RegisterAllDevices() {
			//RegisterDevice(Button0);
			//RegisterDevice(Button1);
			//RegisterDevice(Led);
			//RegisterDevice(PressureSensor);
			RegisterDevice(IMU);
			foreach (PWM[] pwms in PWM.Values) {
				foreach (PWM pwm in pwms) {
					RegisterDevice(pwm);
				}
			}
			//RegisterDevice(TwiSettings);
		}

	}
}
