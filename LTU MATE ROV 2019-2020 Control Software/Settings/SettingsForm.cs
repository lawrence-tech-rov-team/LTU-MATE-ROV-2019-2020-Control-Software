using JsonSerializable;
using LTU_MATE_ROV_2019_2020_Control_Software.Controls;
using LTU_MATE_ROV_2019_2020_Control_Software.Robot;
using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.Actuators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Settings {
	public partial class SettingsForm : Form {

		private RobotThread thread;
		private ControlsThread controls;
		private AppSettings settings;

		public SettingsForm(RobotThread Robot, ControlsThread Controls, AppSettings Settings) {
			InitializeComponent();
			thread = Robot;
			controls = Controls;
			settings = Settings;
		}

		private void SettingsForm_Load(object sender, EventArgs e) {
			MinPulseUpDown.Minimum = MaxPulseUpDown.Minimum = ushort.MinValue;
			MinPulseUpDown.Maximum = MaxPulseUpDown.Maximum = ushort.MaxValue;
			controls.Enabled = false;
		}

		private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e) {
			controls.Enabled = true;

			bool retry = false;
			do {
				if (!settings.Save()) {
					DialogResult result = MessageBox.Show("Unable to save settings. Would you like to try again?", "Error", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
					if (result == DialogResult.Yes) retry = true;
					else if (result == DialogResult.Cancel) e.Cancel = true;
				}
			} while (retry);
		}

		private void ServoSelector_DropDown(object sender, EventArgs e) {
			ServoSelector.Items.Clear();
			ROV robot = thread.Robot;
			if (robot != null) {
				foreach(KeyValuePair<char, Servo[]> servos in robot.Servos) {
					for(int i = 0; i < servos.Value.Length; i++) {
						ServoSelector.Items.Add(new ServoWrapper(servos.Value[i], servos.Key + (i + 1).ToString()));
					}
				}
			}
		}

		private void ServoSelector_SelectedIndexChanged(object sender, EventArgs e) {
			bool enabled = false;
			object obj = ServoSelector.SelectedItem;
			if((obj != null) && (obj is ServoWrapper wrapper)) {
				Servo servo = wrapper.Servo;
				enabled = true;
				MinPulseUpDown.ValueChanged -= MinPulseUpDown_ValueChanged;
				MaxPulseUpDown.ValueChanged -= MaxPulseUpDown_ValueChanged;
				{
					MinPulseUpDown.Value = servo.MinimumPulse;
					MaxPulseUpDown.Value = servo.MaximumPulse;
				}
				MinPulseUpDown.ValueChanged += MinPulseUpDown_ValueChanged;
				MaxPulseUpDown.ValueChanged += MaxPulseUpDown_ValueChanged;
				settings.ServoRanges[wrapper.Name] = servo.PulseRange;
			}

			EnableBtn.Enabled = enabled;
			DisableBtn.Enabled = enabled;
			MinPulseUpDown.Enabled = enabled;
			MaxPulseUpDown.Enabled = enabled;
		}

		private void MinPulseUpDown_ValueChanged(object sender, EventArgs e) {
			object obj = ServoSelector.SelectedItem;
			if((obj != null) && (obj is ServoWrapper wrapper)) {
				Servo servo = wrapper.Servo;
				ushort pulse = decimal.ToUInt16(MinPulseUpDown.Value);
				servo.MinimumPulse = pulse;
				servo.Pulse = pulse;
				settings.ServoRanges[wrapper.Name] = servo.PulseRange;
			}
		}

		private void MaxPulseUpDown_ValueChanged(object sender, EventArgs e) {
			object obj = ServoSelector.SelectedItem;
			if ((obj != null) && (obj is ServoWrapper wrapper)) {
				Servo servo = wrapper.Servo;
				ushort pulse = decimal.ToUInt16(MaxPulseUpDown.Value);
				servo.MaximumPulse = pulse;
				servo.Pulse = pulse;
				settings.ServoRanges[wrapper.Name] = servo.PulseRange;
			}
		}

		private void EnableBtn_Click(object sender, EventArgs e) {
			object obj = ServoSelector.SelectedItem;
			if((obj != null) && (obj is ServoWrapper wrapper)) {
				Servo servo = wrapper.Servo;
				servo.Enabled = true;
			}
		}

		private void DisableBtn_Click(object sender, EventArgs e) {
			object obj = ServoSelector.SelectedItem;
			if ((obj != null) && (obj is ServoWrapper wrapper)) {
				Servo servo = wrapper.Servo;
				servo.Enabled = false;
			}
		}

		private class ServoWrapper : IJsonSerializable {

			public string Name;
			public Servo Servo;

			public ServoWrapper(Servo servo, string name) {
				Name = name;
				Servo = servo;
			}

			public bool LoadFromJson(JsonData Data) {
				throw new NotImplementedException();
			}

			public JsonData SaveToJson() {
				throw new NotImplementedException();
			}

			public override string ToString() {
				return Name;
			}

		}

	}
}
