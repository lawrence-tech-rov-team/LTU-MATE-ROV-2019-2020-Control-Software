using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTU_MATE_ROV_2019_2020_Control_Software.InputControls.Keyboard {
	public class KeyboardProgram : InputProgram {

		private const float ThrustMod = 0.33f;
		private const float ThrustDecay = 0.75f;
		private Twist twist;

		private Stopwatch timer = new Stopwatch();

		public static readonly KeyboardProgram InputDevice = new KeyboardProgram();
		private static volatile IKeyboardListener listener;
		public static IKeyboardListener KeyListener {
			get => listener;
			set {
				if(listener != null) {
					listener.KeyDown -= InputDevice.OnKeyDown;
					listener.KeyUp -= InputDevice.OnKeyUp;
					InputDevice.reset();
				}
				listener = value;
				if(value != null) {
					value.KeyDown += InputDevice.OnKeyDown;
					value.KeyUp += InputDevice.OnKeyUp;
				}
			}
		}

		private volatile bool W = false;
		private volatile bool S = false;

		private void OnKeyDown(object sender, KeyEventArgs e) {
			setKeyState(e.KeyCode, true);
		}

		private void OnKeyUp(object sender, KeyEventArgs e) {
			setKeyState(e.KeyCode, false);
		}

		private void setKeyState(Keys key, bool state) {
			switch (key) {
				case Keys.W:
					W = state;
					break;
				case Keys.S:
					S = state;
					break;
			}
		}

		private KeyboardProgram() {
		}

		private void reset() {
			W = S = false;
		}

		public override string Name => "Keyboard";

		public override void Initialize() {
			
		}

		public override bool Loop() {
			int thrust = 0;
			if (W) thrust++;
			if (S) thrust--;
			long t = timer.ElapsedMilliseconds;

			float Thrust = twist.Linear.X;
			if ((thrust == 0) || ((thrust > 0) && (Thrust < 0)) || ((thrust < 0) && (Thrust > 0))) {
				if (Thrust > 0) twist.Linear.X = Math.Max(0, Thrust - ThrustDecay * t / 1000f);
				else twist.Linear.X = Math.Min(0, Thrust + ThrustDecay * t / 1000f);
			} else {
				twist.Linear.X += thrust * ThrustMod * t / 1000f;
				twist.Linear.X = Math.Max(-1, Math.Min(1, twist.Linear.X));
			}

			Input = twist;
			timer.Restart();

			return Sleep(33);
		}

		public override void Cleanup() {
			//	KeyListener = null;
			Input = new Twist();
		}
	}
}
