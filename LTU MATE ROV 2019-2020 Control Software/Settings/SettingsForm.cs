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
using System.Net;
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
			controls.Enabled = false;

			MinPulseUpDown.Minimum = MaxPulseUpDown.Minimum = ushort.MinValue;
			MinPulseUpDown.Maximum = MaxPulseUpDown.Maximum = ushort.MaxValue;

			ThrusterMinPulse.Minimum = ThrusterZeroPulse.Minimum = ThrusterMaxPulse.Minimum = ushort.MinValue;
			ThrusterMinPulse.Maximum = ThrusterZeroPulse.Maximum = ThrusterMaxPulse.Maximum = ushort.MaxValue;

			SpongeOpenPos.Value = settings.SpongeGripper.OpenAngle;
			SpongeClosedPos.Value = settings.SpongeGripper.ClosedAngle;
			MediumOpenPos.Value = settings.MediumGripper.OpenAngle;
			MediumClosedPos.Value = settings.MediumGripper.ClosedAngle;
			SmallOpenPos.Value = settings.SmallGripper.OpenAngle;
			SmallClosedPos.Value = settings.SmallGripper.ClosedAngle;
			TinyOpenPos.Value = settings.TinyGripper.OpenAngle;
			TinyClosedPos.Value = settings.TinyGripper.ClosedAngle;
			NetOpenPos.Value = settings.NetGripper.OpenAngle;
			NetClosedPos.Value = settings.NetGripper.ClosedAngle;

			IpTextBox.Text = settings.RobotIP.ToString();

			PortSelector.Maximum = IPEndPoint.MaxPort;
			PortSelector.Value = settings.RobotPort;
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

		#region Servo Settings
		private void ServoSelector_DropDown(object sender, EventArgs e) {
			ServoSelector.Items.Clear();
			ROV robot = thread.Robot;
			if (robot != null) {
				foreach(KeyValuePair<string, Servo> servo in robot.Servos) {
					ServoSelector.Items.Add(new ServoWrapper(servo.Value, servo.Key));
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
					MinPulseUpDown.Value = servo.PWM.MinimumPulse;
					MaxPulseUpDown.Value = servo.PWM.MaximumPulse;
				}
				MinPulseUpDown.ValueChanged += MinPulseUpDown_ValueChanged;
				MaxPulseUpDown.ValueChanged += MaxPulseUpDown_ValueChanged;
				settings.ServoRanges[wrapper.Name] = servo.PWM.PulseRange;
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
				servo.PWM.MinimumPulse = pulse;
				servo.PWM.Pulse = pulse;
				settings.ServoRanges[wrapper.Name] = servo.PWM.PulseRange;
			}
		}

		private void MaxPulseUpDown_ValueChanged(object sender, EventArgs e) {
			object obj = ServoSelector.SelectedItem;
			if ((obj != null) && (obj is ServoWrapper wrapper)) {
				Servo servo = wrapper.Servo;
				ushort pulse = decimal.ToUInt16(MaxPulseUpDown.Value);
				servo.PWM.MaximumPulse = pulse;
				servo.PWM.Pulse = pulse;
				settings.ServoRanges[wrapper.Name] = servo.PWM.PulseRange;
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
		#endregion

		#region Thruster Settings
		private void ThrusterSelector_DropDown(object sender, EventArgs e) {
			ThrusterSelector.Items.Clear();
			ROV robot = thread.Robot;
			if (robot != null) {
				foreach (KeyValuePair<string, Thruster> thruster in robot.Thrusters) {
					ThrusterSelector.Items.Add(new ThrusterWrapper(thruster.Value, thruster.Key));
				}
			}
		}

		private void ThrusterSelector_SelectedIndexChanged(object sender, EventArgs e) {
			bool enabled = false;
			object obj = ThrusterSelector.SelectedItem;
			if ((obj != null) && (obj is ThrusterWrapper wrapper)) {
				Thruster thruster = wrapper.Thruster;
				enabled = true;
				ThrusterMinPulse.ValueChanged -= ThrusterMinPulse_ValueChanged;
				ThrusterZeroPulse.ValueChanged -= ThrusterZeroPulse_ValueChanged;
				ThrusterMaxPulse.ValueChanged -= ThrusterMaxPulse_ValueChanged;
				{
					ThrusterMinPulse.Value = thruster.MinimumPulse;
					ThrusterZeroPulse.Value = thruster.ZeroPulse;
					ThrusterMaxPulse.Value = thruster.MaximumPulse;
				}
				ThrusterMinPulse.ValueChanged += ThrusterMinPulse_ValueChanged;
				ThrusterZeroPulse.ValueChanged += ThrusterZeroPulse_ValueChanged;
				ThrusterMaxPulse.ValueChanged += ThrusterMaxPulse_ValueChanged;
				settings.ThrusterRanges[wrapper.Name] = thruster.PulseRange;
			}

			EnableThrustBtn.Enabled = enabled;
			DisableThrustBtn.Enabled = enabled;
			StopThrustBtn.Enabled = enabled;
			ThrusterMinPulse.Enabled = enabled;
			ThrusterZeroPulse.Enabled = enabled;
			ThrusterMaxPulse.Enabled = enabled;
		}

		private void ThrusterMinPulse_ValueChanged(object sender, EventArgs e) {
			object obj = ThrusterSelector.SelectedItem;
			if ((obj != null) && (obj is ThrusterWrapper wrapper)) {
				Thruster thruster = wrapper.Thruster;
				ushort pulse = decimal.ToUInt16(ThrusterMinPulse.Value);
				thruster.MinimumPulse = pulse;
				thruster.Thrust = -1f;
				settings.ThrusterRanges[wrapper.Name] = thruster.PulseRange;
			}
		}

		private void ThrusterZeroPulse_ValueChanged(object sender, EventArgs e) {
			object obj = ThrusterSelector.SelectedItem;
			if ((obj != null) && (obj is ThrusterWrapper wrapper)) {
				Thruster thruster = wrapper.Thruster;
				ushort pulse = decimal.ToUInt16(ThrusterZeroPulse.Value);
				thruster.ZeroPulse = pulse;
				thruster.Stop();
				settings.ThrusterRanges[wrapper.Name] = thruster.PulseRange;
			}
		}

		private void ThrusterMaxPulse_ValueChanged(object sender, EventArgs e) {
			object obj = ThrusterSelector.SelectedItem;
			if ((obj != null) && (obj is ThrusterWrapper wrapper)) {
				Thruster thruster = wrapper.Thruster;
				ushort pulse = decimal.ToUInt16(ThrusterMaxPulse.Value);
				thruster.MaximumPulse = pulse;
				thruster.Thrust = 1f;
				settings.ThrusterRanges[wrapper.Name] = thruster.PulseRange;
			}
		}

		private void EnableThrustBtn_Click(object sender, EventArgs e) {
			object obj = ThrusterSelector.SelectedItem;
			if ((obj != null) && (obj is ThrusterWrapper wrapper)) {
				Thruster thruster = wrapper.Thruster;
				thruster.Enabled = true;
			}
		}

		private void DisableThrustBtn_Click(object sender, EventArgs e) {
			object obj = ThrusterSelector.SelectedItem;
			if ((obj != null) && (obj is ThrusterWrapper wrapper)) {
				Thruster thruster = wrapper.Thruster;
				thruster.Enabled = false;
			}
		}

		private void StopThrustBtn_Click(object sender, EventArgs e) {
			object obj = ThrusterSelector.SelectedItem;
			if ((obj != null) && (obj is ThrusterWrapper wrapper)) {
				Thruster thruster = wrapper.Thruster;
				thruster.Stop();
			}
		}
		#endregion

		#region Gripper Position
		private void SpongeOpenPos_ValueChanged(object sender, EventArgs e) {
			settings.SpongeGripper.OpenAngle = decimal.ToUInt16(SpongeOpenPos.Value);
		}

		private void SpongeClosedPos_ValueChanged(object sender, EventArgs e) {
			settings.SpongeGripper.ClosedAngle = decimal.ToUInt16(SpongeClosedPos.Value);
		}

		private void MediumOpenPos_ValueChanged(object sender, EventArgs e) {
			settings.MediumGripper.OpenAngle = decimal.ToUInt16(MediumOpenPos.Value);
		}

		private void MediumClosedPos_ValueChanged(object sender, EventArgs e) {
			settings.MediumGripper.ClosedAngle = decimal.ToUInt16(MediumClosedPos.Value);
		}

		private void SmallOpenPos_ValueChanged(object sender, EventArgs e) {
			settings.SmallGripper.OpenAngle = decimal.ToUInt16(SmallOpenPos.Value);
		}

		private void SmallClosedPos_ValueChanged(object sender, EventArgs e) {
			settings.SmallGripper.ClosedAngle = decimal.ToUInt16(SmallClosedPos.Value);
		}

		private void TinyOpenPos_ValueChanged(object sender, EventArgs e) {
			settings.TinyGripper.OpenAngle = decimal.ToUInt16(TinyOpenPos.Value);
		}

		private void TinyClosedPos_ValueChanged(object sender, EventArgs e) {
			settings.TinyGripper.ClosedAngle = decimal.ToUInt16(TinyClosedPos.Value);
		}

		private void NetOpenPos_ValueChanged(object sender, EventArgs e) {
			settings.NetGripper.OpenAngle = decimal.ToUInt16(NetOpenPos.Value);
		}

		private void NetClosedPos_ValueChanged(object sender, EventArgs e) {
			settings.NetGripper.ClosedAngle = decimal.ToUInt16(NetClosedPos.Value);
		}
		#endregion

		private void PortSelector_ValueChanged(object sender, EventArgs e) {
			int port = decimal.ToInt32(PortSelector.Value);
			if(port >= IPEndPoint.MinPort && port <= IPEndPoint.MaxPort) {
				settings.RobotPort = port;
			}
		}

		private void IpTextBox_TextChanged(object sender, EventArgs e) {
			IPAddress parsedAddress;
			if(IPAddress.TryParse(IpTextBox.Text, out parsedAddress)) {
				settings.RobotIP = parsedAddress;
				IpTextBox.ForeColor = SystemColors.WindowText;
			} else {
				settings.RobotIP = null;
				IpTextBox.ForeColor = Color.Red;
			}
		}

		private class ServoWrapper {

			public string Name;
			public Servo Servo;

			public ServoWrapper(Servo servo, string name) {
				Name = name;
				Servo = servo;
			}

			public override string ToString() {
				return Name;
			}

		}

		private class ThrusterWrapper {

			public string Name;
			public Thruster Thruster;

			public ThrusterWrapper(Thruster thruster, string name) {
				Name = name;
				Thruster = thruster;
			}

			public override string ToString() {
				return Name;
			}

		}

	}
}
