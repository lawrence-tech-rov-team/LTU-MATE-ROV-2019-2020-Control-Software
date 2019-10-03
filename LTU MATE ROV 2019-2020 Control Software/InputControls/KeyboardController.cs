using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTU_MATE_ROV_2019_2020_Control_Software.InputControls {
	public class KeyboardController : IController {

		private const float ThrustMod = 0.33f;
		private const float ThrustDecay = 0.75f;
		private Stopwatch timer = new Stopwatch();

		private IKeyboardListener listener;
		public IKeyboardListener KeyListener {
			get => listener;
			set {
				if(listener != null) {
					listener.KeyDown -= OnKeyDown;
					listener.KeyUp -= OnKeyUp;
					reset();
				}
				listener = value;
				if(value != null) {
					value.KeyDown += OnKeyDown;
					value.KeyUp += OnKeyUp;
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

		private void reset() {
			W = S = false;
		}

		public float ForwardPower { get; private set; } = 0;

		public float SidePower { get; private set; } = 0;

		public bool Connect() {
			return true;
		}

		public void Disconnect() {
			KeyListener = null;
		}

		public void Update() {
			int thrust = 0;
			if (W) thrust++;
			if (S) thrust--;
			long t = timer.ElapsedMilliseconds;

			if((thrust == 0) || ((thrust > 0) && (ForwardPower < 0)) || ((thrust < 0) && (ForwardPower > 0))) {
				if (ForwardPower > 0) ForwardPower = Math.Max(0, ForwardPower - ThrustDecay * t / 1000f);
				else ForwardPower = Math.Min(0, ForwardPower + ThrustDecay * t / 1000f);
			} else {
				ForwardPower += thrust * ThrustMod * t / 1000f;
				ForwardPower = Math.Max(-1, Math.Min(1, ForwardPower));
			}

			timer.Restart();
		}

	}
}
