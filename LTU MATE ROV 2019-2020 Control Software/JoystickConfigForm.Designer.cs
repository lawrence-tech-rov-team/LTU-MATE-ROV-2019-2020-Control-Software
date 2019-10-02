namespace LTU_MATE_ROV_2019_2020_Control_Software {
	partial class JoystickConfigForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.AxisPointer = new Meters.DoubleAxisPointer();
			this.Btn11 = new Meters.IOMeter();
			this.Btn10 = new Meters.IOMeter();
			this.Btn9 = new Meters.IOMeter();
			this.Btn8 = new Meters.IOMeter();
			this.Btn7 = new Meters.IOMeter();
			this.Btn6 = new Meters.IOMeter();
			this.Btn5 = new Meters.IOMeter();
			this.Btn4 = new Meters.IOMeter();
			this.Btn3 = new Meters.IOMeter();
			this.Btn2 = new Meters.IOMeter();
			this.Btn1 = new Meters.IOMeter();
			this.Btn0 = new Meters.IOMeter();
			this.YawMeter = new Meters.LinearMeter();
			this.RollMeter = new Meters.LinearMeter();
			this.PitchMeter = new Meters.LinearMeter();
			this.PowerMeter = new Meters.LinearMeter();
			this.DeviceSelector = new System.Windows.Forms.ComboBox();
			this.PollingRateInput = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.HatMeter = new Meters.DirectionalMeter();
			this.InputTimer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.PollingRateInput)).BeginInit();
			this.SuspendLayout();
			// 
			// AxisPointer
			// 
			this.AxisPointer.BackColor = System.Drawing.Color.White;
			this.AxisPointer.BorderColor = System.Drawing.Color.Black;
			this.AxisPointer.Location = new System.Drawing.Point(65, 40);
			this.AxisPointer.MeterColor = System.Drawing.Color.Red;
			this.AxisPointer.MeterRadius = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.AxisPointer.Name = "AxisPointer";
			this.AxisPointer.Size = new System.Drawing.Size(200, 200);
			this.AxisPointer.TabIndex = 50;
			this.AxisPointer.XInverse = false;
			this.AxisPointer.XMaximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.AxisPointer.XMinimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.AxisPointer.XValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.AxisPointer.YInverse = true;
			this.AxisPointer.YMaximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.AxisPointer.YMinimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.AxisPointer.YValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// Btn11
			// 
			this.Btn11.BorderColor = System.Drawing.Color.Black;
			this.Btn11.Location = new System.Drawing.Point(214, 339);
			this.Btn11.Name = "Btn11";
			this.Btn11.OffColor = System.Drawing.Color.Firebrick;
			this.Btn11.OnColor = System.Drawing.Color.Red;
			this.Btn11.Size = new System.Drawing.Size(35, 35);
			this.Btn11.Style = Meters.ButtonStyle.Round;
			this.Btn11.TabIndex = 49;
			this.Btn11.Text = "11";
			this.Btn11.UseVisualStyleBackColor = true;
			this.Btn11.Value = false;
			// 
			// Btn10
			// 
			this.Btn10.BorderColor = System.Drawing.Color.Black;
			this.Btn10.Location = new System.Drawing.Point(173, 339);
			this.Btn10.Name = "Btn10";
			this.Btn10.OffColor = System.Drawing.Color.Firebrick;
			this.Btn10.OnColor = System.Drawing.Color.Red;
			this.Btn10.Size = new System.Drawing.Size(35, 35);
			this.Btn10.Style = Meters.ButtonStyle.Round;
			this.Btn10.TabIndex = 48;
			this.Btn10.Text = "10";
			this.Btn10.UseVisualStyleBackColor = true;
			this.Btn10.Value = false;
			// 
			// Btn9
			// 
			this.Btn9.BorderColor = System.Drawing.Color.Black;
			this.Btn9.Location = new System.Drawing.Point(132, 339);
			this.Btn9.Name = "Btn9";
			this.Btn9.OffColor = System.Drawing.Color.Firebrick;
			this.Btn9.OnColor = System.Drawing.Color.Red;
			this.Btn9.Size = new System.Drawing.Size(35, 35);
			this.Btn9.Style = Meters.ButtonStyle.Round;
			this.Btn9.TabIndex = 47;
			this.Btn9.Text = "9";
			this.Btn9.UseVisualStyleBackColor = true;
			this.Btn9.Value = false;
			// 
			// Btn8
			// 
			this.Btn8.BorderColor = System.Drawing.Color.Black;
			this.Btn8.Location = new System.Drawing.Point(91, 339);
			this.Btn8.Name = "Btn8";
			this.Btn8.OffColor = System.Drawing.Color.Firebrick;
			this.Btn8.OnColor = System.Drawing.Color.Red;
			this.Btn8.Size = new System.Drawing.Size(35, 35);
			this.Btn8.Style = Meters.ButtonStyle.Round;
			this.Btn8.TabIndex = 46;
			this.Btn8.Text = "8";
			this.Btn8.UseVisualStyleBackColor = true;
			this.Btn8.Value = false;
			// 
			// Btn7
			// 
			this.Btn7.BorderColor = System.Drawing.Color.Black;
			this.Btn7.Location = new System.Drawing.Point(50, 339);
			this.Btn7.Name = "Btn7";
			this.Btn7.OffColor = System.Drawing.Color.Firebrick;
			this.Btn7.OnColor = System.Drawing.Color.Red;
			this.Btn7.Size = new System.Drawing.Size(35, 35);
			this.Btn7.Style = Meters.ButtonStyle.Round;
			this.Btn7.TabIndex = 45;
			this.Btn7.Text = "7";
			this.Btn7.UseVisualStyleBackColor = true;
			this.Btn7.Value = false;
			// 
			// Btn6
			// 
			this.Btn6.BorderColor = System.Drawing.Color.Black;
			this.Btn6.Location = new System.Drawing.Point(9, 339);
			this.Btn6.Name = "Btn6";
			this.Btn6.OffColor = System.Drawing.Color.Firebrick;
			this.Btn6.OnColor = System.Drawing.Color.Red;
			this.Btn6.Size = new System.Drawing.Size(35, 35);
			this.Btn6.Style = Meters.ButtonStyle.Round;
			this.Btn6.TabIndex = 44;
			this.Btn6.Text = "6";
			this.Btn6.UseVisualStyleBackColor = true;
			this.Btn6.Value = false;
			// 
			// Btn5
			// 
			this.Btn5.BorderColor = System.Drawing.Color.Black;
			this.Btn5.Location = new System.Drawing.Point(214, 298);
			this.Btn5.Name = "Btn5";
			this.Btn5.OffColor = System.Drawing.Color.Firebrick;
			this.Btn5.OnColor = System.Drawing.Color.Red;
			this.Btn5.Size = new System.Drawing.Size(35, 35);
			this.Btn5.Style = Meters.ButtonStyle.Round;
			this.Btn5.TabIndex = 43;
			this.Btn5.Text = "5";
			this.Btn5.UseVisualStyleBackColor = true;
			this.Btn5.Value = false;
			// 
			// Btn4
			// 
			this.Btn4.BorderColor = System.Drawing.Color.Black;
			this.Btn4.Location = new System.Drawing.Point(173, 298);
			this.Btn4.Name = "Btn4";
			this.Btn4.OffColor = System.Drawing.Color.Firebrick;
			this.Btn4.OnColor = System.Drawing.Color.Red;
			this.Btn4.Size = new System.Drawing.Size(35, 35);
			this.Btn4.Style = Meters.ButtonStyle.Round;
			this.Btn4.TabIndex = 42;
			this.Btn4.Text = "4";
			this.Btn4.UseVisualStyleBackColor = true;
			this.Btn4.Value = false;
			// 
			// Btn3
			// 
			this.Btn3.BorderColor = System.Drawing.Color.Black;
			this.Btn3.Location = new System.Drawing.Point(132, 298);
			this.Btn3.Name = "Btn3";
			this.Btn3.OffColor = System.Drawing.Color.Firebrick;
			this.Btn3.OnColor = System.Drawing.Color.Red;
			this.Btn3.Size = new System.Drawing.Size(35, 35);
			this.Btn3.Style = Meters.ButtonStyle.Round;
			this.Btn3.TabIndex = 41;
			this.Btn3.Text = "3";
			this.Btn3.UseVisualStyleBackColor = true;
			this.Btn3.Value = false;
			// 
			// Btn2
			// 
			this.Btn2.BorderColor = System.Drawing.Color.Black;
			this.Btn2.Location = new System.Drawing.Point(91, 298);
			this.Btn2.Name = "Btn2";
			this.Btn2.OffColor = System.Drawing.Color.Firebrick;
			this.Btn2.OnColor = System.Drawing.Color.Red;
			this.Btn2.Size = new System.Drawing.Size(35, 35);
			this.Btn2.Style = Meters.ButtonStyle.Round;
			this.Btn2.TabIndex = 40;
			this.Btn2.Text = "2";
			this.Btn2.UseVisualStyleBackColor = true;
			this.Btn2.Value = false;
			// 
			// Btn1
			// 
			this.Btn1.BorderColor = System.Drawing.Color.Black;
			this.Btn1.Location = new System.Drawing.Point(50, 298);
			this.Btn1.Name = "Btn1";
			this.Btn1.OffColor = System.Drawing.Color.Firebrick;
			this.Btn1.OnColor = System.Drawing.Color.Red;
			this.Btn1.Size = new System.Drawing.Size(35, 35);
			this.Btn1.Style = Meters.ButtonStyle.Round;
			this.Btn1.TabIndex = 39;
			this.Btn1.Text = "1";
			this.Btn1.UseVisualStyleBackColor = true;
			this.Btn1.Value = false;
			// 
			// Btn0
			// 
			this.Btn0.BorderColor = System.Drawing.Color.Black;
			this.Btn0.Location = new System.Drawing.Point(9, 298);
			this.Btn0.Name = "Btn0";
			this.Btn0.OffColor = System.Drawing.Color.Firebrick;
			this.Btn0.OnColor = System.Drawing.Color.Red;
			this.Btn0.Size = new System.Drawing.Size(35, 35);
			this.Btn0.Style = Meters.ButtonStyle.Round;
			this.Btn0.TabIndex = 38;
			this.Btn0.Text = "0";
			this.Btn0.UseVisualStyleBackColor = true;
			this.Btn0.Value = false;
			// 
			// YawMeter
			// 
			this.YawMeter.BackColor = System.Drawing.Color.White;
			this.YawMeter.BorderColor = System.Drawing.Color.Black;
			this.YawMeter.Horizontal = true;
			this.YawMeter.Inverse = false;
			this.YawMeter.Location = new System.Drawing.Point(65, 272);
			this.YawMeter.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.YawMeter.MeterColor = System.Drawing.Color.Red;
			this.YawMeter.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.YawMeter.Name = "YawMeter";
			this.YawMeter.Size = new System.Drawing.Size(200, 20);
			this.YawMeter.TabIndex = 37;
			this.YawMeter.Value = new decimal(new int[] {
            32767,
            0,
            0,
            0});
			this.YawMeter.ZeroValue = new decimal(new int[] {
            32767,
            0,
            0,
            0});
			// 
			// RollMeter
			// 
			this.RollMeter.BackColor = System.Drawing.Color.White;
			this.RollMeter.BorderColor = System.Drawing.Color.Black;
			this.RollMeter.Horizontal = true;
			this.RollMeter.Inverse = false;
			this.RollMeter.Location = new System.Drawing.Point(65, 246);
			this.RollMeter.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.RollMeter.MeterColor = System.Drawing.Color.Red;
			this.RollMeter.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.RollMeter.Name = "RollMeter";
			this.RollMeter.Size = new System.Drawing.Size(200, 20);
			this.RollMeter.TabIndex = 36;
			this.RollMeter.Value = new decimal(new int[] {
            32767,
            0,
            0,
            0});
			this.RollMeter.ZeroValue = new decimal(new int[] {
            32767,
            0,
            0,
            0});
			// 
			// PitchMeter
			// 
			this.PitchMeter.BackColor = System.Drawing.Color.White;
			this.PitchMeter.BorderColor = System.Drawing.Color.Black;
			this.PitchMeter.Horizontal = false;
			this.PitchMeter.Inverse = true;
			this.PitchMeter.Location = new System.Drawing.Point(38, 40);
			this.PitchMeter.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.PitchMeter.MeterColor = System.Drawing.Color.Red;
			this.PitchMeter.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.PitchMeter.Name = "PitchMeter";
			this.PitchMeter.Size = new System.Drawing.Size(20, 200);
			this.PitchMeter.TabIndex = 35;
			this.PitchMeter.Value = new decimal(new int[] {
            32767,
            0,
            0,
            0});
			this.PitchMeter.ZeroValue = new decimal(new int[] {
            32767,
            0,
            0,
            0});
			// 
			// PowerMeter
			// 
			this.PowerMeter.BackColor = System.Drawing.Color.White;
			this.PowerMeter.BorderColor = System.Drawing.Color.Black;
			this.PowerMeter.Horizontal = false;
			this.PowerMeter.Inverse = true;
			this.PowerMeter.Location = new System.Drawing.Point(12, 40);
			this.PowerMeter.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.PowerMeter.MeterColor = System.Drawing.Color.Red;
			this.PowerMeter.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.PowerMeter.Name = "PowerMeter";
			this.PowerMeter.Size = new System.Drawing.Size(20, 200);
			this.PowerMeter.TabIndex = 34;
			this.PowerMeter.Value = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.PowerMeter.ZeroValue = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			// 
			// DeviceSelector
			// 
			this.DeviceSelector.FormattingEnabled = true;
			this.DeviceSelector.Location = new System.Drawing.Point(9, 10);
			this.DeviceSelector.Name = "DeviceSelector";
			this.DeviceSelector.Size = new System.Drawing.Size(121, 24);
			this.DeviceSelector.TabIndex = 33;
			this.DeviceSelector.DropDown += new System.EventHandler(this.DeviceSelector_DropDown);
			this.DeviceSelector.SelectedIndexChanged += new System.EventHandler(this.DeviceSelector_SelectedIndexChanged);
			// 
			// PollingRateInput
			// 
			this.PollingRateInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.PollingRateInput.Location = new System.Drawing.Point(103, 385);
			this.PollingRateInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.PollingRateInput.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
			this.PollingRateInput.Name = "PollingRateInput";
			this.PollingRateInput.Size = new System.Drawing.Size(53, 22);
			this.PollingRateInput.TabIndex = 32;
			this.PollingRateInput.Value = new decimal(new int[] {
            34,
            0,
            0,
            0});
			this.PollingRateInput.ValueChanged += new System.EventHandler(this.PollingRateInput_ValueChanged);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 390);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 17);
			this.label2.TabIndex = 31;
			this.label2.Text = "Polling Rate:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// HatMeter
			// 
			this.HatMeter.Location = new System.Drawing.Point(271, 40);
			this.HatMeter.Name = "HatMeter";
			this.HatMeter.OffColor = System.Drawing.Color.Blue;
			this.HatMeter.OnColor = System.Drawing.Color.OrangeRed;
			this.HatMeter.Size = new System.Drawing.Size(198, 147);
			this.HatMeter.TabIndex = 51;
			this.HatMeter.Value = Meters.POVDirection.Center;
			// 
			// InputTimer
			// 
			this.InputTimer.Interval = 34;
			this.InputTimer.Tick += new System.EventHandler(this.InputTimer_Tick);
			// 
			// JoystickConfigForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.HatMeter);
			this.Controls.Add(this.AxisPointer);
			this.Controls.Add(this.Btn11);
			this.Controls.Add(this.Btn10);
			this.Controls.Add(this.Btn9);
			this.Controls.Add(this.Btn8);
			this.Controls.Add(this.Btn7);
			this.Controls.Add(this.Btn6);
			this.Controls.Add(this.Btn5);
			this.Controls.Add(this.Btn4);
			this.Controls.Add(this.Btn3);
			this.Controls.Add(this.Btn2);
			this.Controls.Add(this.Btn1);
			this.Controls.Add(this.Btn0);
			this.Controls.Add(this.YawMeter);
			this.Controls.Add(this.RollMeter);
			this.Controls.Add(this.PitchMeter);
			this.Controls.Add(this.PowerMeter);
			this.Controls.Add(this.DeviceSelector);
			this.Controls.Add(this.PollingRateInput);
			this.Controls.Add(this.label2);
			this.Name = "JoystickConfigForm";
			this.Text = "JoystickConfigForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JoystickConfigForm_FormClosing);
			this.Load += new System.EventHandler(this.JoystickConfigForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.PollingRateInput)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Meters.DoubleAxisPointer AxisPointer;
		private Meters.IOMeter Btn11;
		private Meters.IOMeter Btn10;
		private Meters.IOMeter Btn9;
		private Meters.IOMeter Btn8;
		private Meters.IOMeter Btn7;
		private Meters.IOMeter Btn6;
		private Meters.IOMeter Btn5;
		private Meters.IOMeter Btn4;
		private Meters.IOMeter Btn3;
		private Meters.IOMeter Btn2;
		private Meters.IOMeter Btn1;
		private Meters.IOMeter Btn0;
		private Meters.LinearMeter YawMeter;
		private Meters.LinearMeter RollMeter;
		private Meters.LinearMeter PitchMeter;
		private Meters.LinearMeter PowerMeter;
		private System.Windows.Forms.ComboBox DeviceSelector;
		private System.Windows.Forms.NumericUpDown PollingRateInput;
		private System.Windows.Forms.Label label2;
		private Meters.DirectionalMeter HatMeter;
		private System.Windows.Forms.Timer InputTimer;
	}
}