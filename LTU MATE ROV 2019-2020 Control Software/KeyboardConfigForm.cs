using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTU_MATE_ROV_2019_2020_Control_Software {
	public partial class KeyboardConfigForm : Form {

		private enum KeyBinding {
			ThrottleUp,
			ThrottleDown,
			SteerLeft
		}

		private KeysConverter keyConverter = new KeysConverter();

		private Dictionary<TextBox, KeyBinding> KeyBindingBoxes = new Dictionary<TextBox, KeyBinding>();
		private Dictionary<Keys, KeyBinding> KeyBindings = new Dictionary<Keys, KeyBinding>();
		private Dictionary<KeyBinding, bool> KeyStates = new Dictionary<KeyBinding, bool>();

		public KeyboardConfigForm() {
			InitializeComponent();

			KeyBindingBoxes.Add(ThrottleFBox, KeyBinding.ThrottleUp);
			KeyBindingBoxes.Add(ThrottleBBox, KeyBinding.ThrottleDown);
			KeyBindingBoxes.Add(SteerLBox, KeyBinding.SteerLeft);
		}

		private void KeyboardConfigForm_Load(object sender, EventArgs e) {
			label1.Focus();

			foreach(TextBox box in KeyBindingBoxes.Keys) {
				box.KeyDown += (object senderTextBox, KeyEventArgs ev) => {
					if (!(senderTextBox is TextBox)) return;
					TextBox send = (TextBox)senderTextBox;

					if (KeyBindingBoxes.ContainsKey(send)) {
						KeyBinding binding = KeyBindingBoxes[send];
						KeyBindings[ev.KeyCode] = binding;
						KeyStates[binding] = false;

						send.Text = keyConverter.ConvertToString(ev.KeyCode);
						this.label1.Focus();
					} else {
						send.Clear();
					}
				};

				box.Enter += (object senderTextBox, EventArgs ev) => {
					if (!(senderTextBox is TextBox)) return;
					TextBox send = (TextBox)senderTextBox;
					send.Clear();

					if (KeyBindingBoxes.ContainsKey(send)) {
						KeyBinding binding = KeyBindingBoxes[send];
						KeyValuePair<Keys, KeyBinding>[] pairs = KeyBindings.Where(pair => pair.Value == binding).ToArray();
						foreach(KeyValuePair<Keys, KeyBinding> pair in pairs) {
							KeyBindings.Remove(pair.Key);
						}
					}
				};
			}

			InputTimer.Start();
		}

		private const decimal ThrustMod = 60; //Amount of thrust added per second
		private const decimal ThrustDecay = 40; //Amount of thrust to decay per second
		private const decimal SteerMod = 80; //Amount of steer added per second
		private const decimal SteerDecay = 50; //Amount of steer to decay per second.

		private decimal Thrust = 0;
		private decimal Steer = 0;

		private void InputTimer_Tick(object sender, EventArgs e) {
			decimal ThrustDir = ((KeyStates.ContainsKey(KeyBinding.ThrottleUp) && KeyStates[KeyBinding.ThrottleUp]) ? 1 : 0) + ((KeyStates.ContainsKey(KeyBinding.ThrottleDown) && KeyStates[KeyBinding.ThrottleDown]) ? -1 : 0);
			decimal SteerDir = ((KeyStates.ContainsKey(KeyBinding.SteerLeft) && KeyStates[KeyBinding.SteerLeft]) ? -1 : 0);

			if(ThrustDir == 0) {
				decimal decay = ThrustDecay * InputTimer.Interval / 1000;
				if (Math.Abs(Thrust) <= decay) Thrust = 0;
				else if (Thrust > 0) Thrust -= decay;
				else Thrust += decay;
			} else {
				Thrust += (ThrustMod * ThrustDir) * InputTimer.Interval / 1000;
			}

			if (SteerDir == 0) {
				decimal decay = SteerDecay * InputTimer.Interval / 1000;
				if (Math.Abs(Steer) <= decay) Steer = 0;
				else if (Steer > 0) Steer -= decay;
				else Steer += decay;
			} else {
				Steer += (SteerMod * SteerDir) * InputTimer.Interval / 1000;
			}

			ThrustMeter.Value = Thrust;
			SteerMeter.Value = Steer;
		}

		private void KeyboardConfigForm_KeyDown(object sender, KeyEventArgs e) {
			KeyBinding binding;
			if (KeyBindings.TryGetValue(e.KeyCode, out binding)) {
				KeyStates[binding] = true;
			}
		}

		private void KeyboardConfigForm_KeyUp(object sender, KeyEventArgs e) {
			KeyBinding binding;
			if (KeyBindings.TryGetValue(e.KeyCode, out binding)) {
				KeyStates[binding] = false;
			}
		}
	}
}
