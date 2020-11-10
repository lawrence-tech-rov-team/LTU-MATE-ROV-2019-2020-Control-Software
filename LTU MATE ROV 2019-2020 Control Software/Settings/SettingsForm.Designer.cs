namespace LTU_MATE_ROV_2019_2020_Control_Software.Settings {
	partial class SettingsForm {
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
			this.ServoSelector = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.DisableBtn = new System.Windows.Forms.Button();
			this.EnableBtn = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.MaxPulseUpDown = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.MinPulseUpDown = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.SpongeOpenPos = new System.Windows.Forms.NumericUpDown();
			this.MediumOpenPos = new System.Windows.Forms.NumericUpDown();
			this.SmallOpenPos = new System.Windows.Forms.NumericUpDown();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.NetClosedPos = new System.Windows.Forms.NumericUpDown();
			this.label17 = new System.Windows.Forms.Label();
			this.NetOpenPos = new System.Windows.Forms.NumericUpDown();
			this.TinyClosedPos = new System.Windows.Forms.NumericUpDown();
			this.label16 = new System.Windows.Forms.Label();
			this.TinyOpenPos = new System.Windows.Forms.NumericUpDown();
			this.SmallClosedPos = new System.Windows.Forms.NumericUpDown();
			this.MediumClosedPos = new System.Windows.Forms.NumericUpDown();
			this.SpongeClosedPos = new System.Windows.Forms.NumericUpDown();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.StopThrustBtn = new System.Windows.Forms.Button();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.ThrusterMaxPulse = new System.Windows.Forms.NumericUpDown();
			this.DisableThrustBtn = new System.Windows.Forms.Button();
			this.label18 = new System.Windows.Forms.Label();
			this.EnableThrustBtn = new System.Windows.Forms.Button();
			this.ThrusterSelector = new System.Windows.Forms.ComboBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.ThrusterMinPulse = new System.Windows.Forms.NumericUpDown();
			this.label21 = new System.Windows.Forms.Label();
			this.ThrusterZeroPulse = new System.Windows.Forms.NumericUpDown();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label25 = new System.Windows.Forms.Label();
			this.IpTextBox = new System.Windows.Forms.TextBox();
			this.label26 = new System.Windows.Forms.Label();
			this.PortSelector = new System.Windows.Forms.NumericUpDown();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MaxPulseUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MinPulseUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SpongeOpenPos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MediumOpenPos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SmallOpenPos)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NetClosedPos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NetOpenPos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TinyClosedPos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TinyOpenPos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SmallClosedPos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MediumClosedPos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SpongeClosedPos)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ThrusterMaxPulse)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ThrusterMinPulse)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ThrusterZeroPulse)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PortSelector)).BeginInit();
			this.SuspendLayout();
			// 
			// ServoSelector
			// 
			this.ServoSelector.FormattingEnabled = true;
			this.ServoSelector.Location = new System.Drawing.Point(62, 19);
			this.ServoSelector.Name = "ServoSelector";
			this.ServoSelector.Size = new System.Drawing.Size(165, 21);
			this.ServoSelector.TabIndex = 0;
			this.ServoSelector.DropDown += new System.EventHandler(this.ServoSelector_DropDown);
			this.ServoSelector.SelectedIndexChanged += new System.EventHandler(this.ServoSelector_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Servo:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.DisableBtn);
			this.groupBox1.Controls.Add(this.EnableBtn);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.MaxPulseUpDown);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.MinPulseUpDown);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.ServoSelector);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(290, 127);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Servo Calibration";
			// 
			// DisableBtn
			// 
			this.DisableBtn.Location = new System.Drawing.Point(172, 69);
			this.DisableBtn.Name = "DisableBtn";
			this.DisableBtn.Size = new System.Drawing.Size(66, 23);
			this.DisableBtn.TabIndex = 10;
			this.DisableBtn.Text = "Disable";
			this.DisableBtn.UseVisualStyleBackColor = true;
			this.DisableBtn.Click += new System.EventHandler(this.DisableBtn_Click);
			// 
			// EnableBtn
			// 
			this.EnableBtn.Location = new System.Drawing.Point(172, 43);
			this.EnableBtn.Name = "EnableBtn";
			this.EnableBtn.Size = new System.Drawing.Size(66, 23);
			this.EnableBtn.TabIndex = 9;
			this.EnableBtn.Text = "Enable";
			this.EnableBtn.UseVisualStyleBackColor = true;
			this.EnableBtn.Click += new System.EventHandler(this.EnableBtn_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(147, 74);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(18, 13);
			this.label8.TabIndex = 8;
			this.label8.Text = "us";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(147, 48);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(18, 13);
			this.label7.TabIndex = 7;
			this.label7.Text = "us";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Maximum:";
			// 
			// MaxPulseUpDown
			// 
			this.MaxPulseUpDown.Location = new System.Drawing.Point(63, 72);
			this.MaxPulseUpDown.Name = "MaxPulseUpDown";
			this.MaxPulseUpDown.Size = new System.Drawing.Size(78, 20);
			this.MaxPulseUpDown.TabIndex = 5;
			this.MaxPulseUpDown.ValueChanged += new System.EventHandler(this.MaxPulseUpDown_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Minimum:";
			// 
			// MinPulseUpDown
			// 
			this.MinPulseUpDown.Location = new System.Drawing.Point(63, 46);
			this.MinPulseUpDown.Name = "MinPulseUpDown";
			this.MinPulseUpDown.Size = new System.Drawing.Size(78, 20);
			this.MinPulseUpDown.TabIndex = 3;
			this.MinPulseUpDown.ValueChanged += new System.EventHandler(this.MinPulseUpDown_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(5, 34);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Sponge:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(5, 60);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Medium:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(5, 86);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Small:";
			// 
			// SpongeOpenPos
			// 
			this.SpongeOpenPos.Location = new System.Drawing.Point(62, 32);
			this.SpongeOpenPos.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
			this.SpongeOpenPos.Name = "SpongeOpenPos";
			this.SpongeOpenPos.Size = new System.Drawing.Size(79, 20);
			this.SpongeOpenPos.TabIndex = 6;
			this.SpongeOpenPos.ValueChanged += new System.EventHandler(this.SpongeOpenPos_ValueChanged);
			// 
			// MediumOpenPos
			// 
			this.MediumOpenPos.Location = new System.Drawing.Point(62, 58);
			this.MediumOpenPos.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
			this.MediumOpenPos.Name = "MediumOpenPos";
			this.MediumOpenPos.Size = new System.Drawing.Size(79, 20);
			this.MediumOpenPos.TabIndex = 7;
			this.MediumOpenPos.ValueChanged += new System.EventHandler(this.MediumOpenPos_ValueChanged);
			// 
			// SmallOpenPos
			// 
			this.SmallOpenPos.Location = new System.Drawing.Point(62, 84);
			this.SmallOpenPos.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
			this.SmallOpenPos.Name = "SmallOpenPos";
			this.SmallOpenPos.Size = new System.Drawing.Size(79, 20);
			this.SmallOpenPos.TabIndex = 8;
			this.SmallOpenPos.ValueChanged += new System.EventHandler(this.SmallOpenPos_ValueChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(233, 86);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(47, 13);
			this.label9.TabIndex = 9;
			this.label9.Text = "Degrees";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(233, 34);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(47, 13);
			this.label10.TabIndex = 10;
			this.label10.Text = "Degrees";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(233, 60);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(47, 13);
			this.label11.TabIndex = 11;
			this.label11.Text = "Degrees";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.NetClosedPos);
			this.groupBox2.Controls.Add(this.label17);
			this.groupBox2.Controls.Add(this.NetOpenPos);
			this.groupBox2.Controls.Add(this.TinyClosedPos);
			this.groupBox2.Controls.Add(this.label16);
			this.groupBox2.Controls.Add(this.TinyOpenPos);
			this.groupBox2.Controls.Add(this.SmallClosedPos);
			this.groupBox2.Controls.Add(this.MediumClosedPos);
			this.groupBox2.Controls.Add(this.SpongeClosedPos);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.SpongeOpenPos);
			this.groupBox2.Controls.Add(this.SmallOpenPos);
			this.groupBox2.Controls.Add(this.MediumOpenPos);
			this.groupBox2.Location = new System.Drawing.Point(12, 145);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(290, 162);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Gripper Positions";
			// 
			// NetClosedPos
			// 
			this.NetClosedPos.Location = new System.Drawing.Point(148, 133);
			this.NetClosedPos.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
			this.NetClosedPos.Name = "NetClosedPos";
			this.NetClosedPos.Size = new System.Drawing.Size(79, 20);
			this.NetClosedPos.TabIndex = 24;
			this.NetClosedPos.ValueChanged += new System.EventHandler(this.NetClosedPos_ValueChanged);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(233, 135);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(47, 13);
			this.label17.TabIndex = 23;
			this.label17.Text = "Degrees";
			// 
			// NetOpenPos
			// 
			this.NetOpenPos.Location = new System.Drawing.Point(62, 133);
			this.NetOpenPos.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
			this.NetOpenPos.Name = "NetOpenPos";
			this.NetOpenPos.Size = new System.Drawing.Size(79, 20);
			this.NetOpenPos.TabIndex = 22;
			this.NetOpenPos.ValueChanged += new System.EventHandler(this.NetOpenPos_ValueChanged);
			// 
			// TinyClosedPos
			// 
			this.TinyClosedPos.Location = new System.Drawing.Point(148, 109);
			this.TinyClosedPos.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
			this.TinyClosedPos.Name = "TinyClosedPos";
			this.TinyClosedPos.Size = new System.Drawing.Size(79, 20);
			this.TinyClosedPos.TabIndex = 21;
			this.TinyClosedPos.ValueChanged += new System.EventHandler(this.TinyClosedPos_ValueChanged);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(233, 110);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(47, 13);
			this.label16.TabIndex = 20;
			this.label16.Text = "Degrees";
			// 
			// TinyOpenPos
			// 
			this.TinyOpenPos.Location = new System.Drawing.Point(62, 109);
			this.TinyOpenPos.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
			this.TinyOpenPos.Name = "TinyOpenPos";
			this.TinyOpenPos.Size = new System.Drawing.Size(79, 20);
			this.TinyOpenPos.TabIndex = 19;
			this.TinyOpenPos.ValueChanged += new System.EventHandler(this.TinyOpenPos_ValueChanged);
			// 
			// SmallClosedPos
			// 
			this.SmallClosedPos.Location = new System.Drawing.Point(148, 84);
			this.SmallClosedPos.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
			this.SmallClosedPos.Name = "SmallClosedPos";
			this.SmallClosedPos.Size = new System.Drawing.Size(79, 20);
			this.SmallClosedPos.TabIndex = 18;
			this.SmallClosedPos.ValueChanged += new System.EventHandler(this.SmallClosedPos_ValueChanged);
			// 
			// MediumClosedPos
			// 
			this.MediumClosedPos.Location = new System.Drawing.Point(148, 58);
			this.MediumClosedPos.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
			this.MediumClosedPos.Name = "MediumClosedPos";
			this.MediumClosedPos.Size = new System.Drawing.Size(79, 20);
			this.MediumClosedPos.TabIndex = 17;
			this.MediumClosedPos.ValueChanged += new System.EventHandler(this.MediumClosedPos_ValueChanged);
			// 
			// SpongeClosedPos
			// 
			this.SpongeClosedPos.Location = new System.Drawing.Point(148, 32);
			this.SpongeClosedPos.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
			this.SpongeClosedPos.Name = "SpongeClosedPos";
			this.SpongeClosedPos.Size = new System.Drawing.Size(79, 20);
			this.SpongeClosedPos.TabIndex = 16;
			this.SpongeClosedPos.ValueChanged += new System.EventHandler(this.SpongeClosedPos_ValueChanged);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(170, 15);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(39, 13);
			this.label15.TabIndex = 15;
			this.label15.Text = "Closed";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(85, 15);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(33, 13);
			this.label14.TabIndex = 14;
			this.label14.Text = "Open";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(6, 135);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(27, 13);
			this.label13.TabIndex = 13;
			this.label13.Text = "Net:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(6, 110);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(30, 13);
			this.label12.TabIndex = 12;
			this.label12.Text = "Tiny:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.StopThrustBtn);
			this.groupBox3.Controls.Add(this.label23);
			this.groupBox3.Controls.Add(this.label24);
			this.groupBox3.Controls.Add(this.ThrusterMaxPulse);
			this.groupBox3.Controls.Add(this.DisableThrustBtn);
			this.groupBox3.Controls.Add(this.label18);
			this.groupBox3.Controls.Add(this.EnableThrustBtn);
			this.groupBox3.Controls.Add(this.ThrusterSelector);
			this.groupBox3.Controls.Add(this.label19);
			this.groupBox3.Controls.Add(this.label22);
			this.groupBox3.Controls.Add(this.label20);
			this.groupBox3.Controls.Add(this.ThrusterMinPulse);
			this.groupBox3.Controls.Add(this.label21);
			this.groupBox3.Controls.Add(this.ThrusterZeroPulse);
			this.groupBox3.Location = new System.Drawing.Point(308, 12);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox3.Size = new System.Drawing.Size(240, 127);
			this.groupBox3.TabIndex = 13;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Thruster Calibration";
			// 
			// StopThrustBtn
			// 
			this.StopThrustBtn.Location = new System.Drawing.Point(171, 92);
			this.StopThrustBtn.Name = "StopThrustBtn";
			this.StopThrustBtn.Size = new System.Drawing.Size(66, 23);
			this.StopThrustBtn.TabIndex = 22;
			this.StopThrustBtn.Text = "Stop";
			this.StopThrustBtn.UseVisualStyleBackColor = true;
			this.StopThrustBtn.Click += new System.EventHandler(this.StopThrustBtn_Click);
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(146, 97);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(18, 13);
			this.label23.TabIndex = 21;
			this.label23.Text = "us";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(4, 97);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(54, 13);
			this.label24.TabIndex = 20;
			this.label24.Text = "Maximum:";
			// 
			// ThrusterMaxPulse
			// 
			this.ThrusterMaxPulse.Location = new System.Drawing.Point(62, 95);
			this.ThrusterMaxPulse.Name = "ThrusterMaxPulse";
			this.ThrusterMaxPulse.Size = new System.Drawing.Size(78, 20);
			this.ThrusterMaxPulse.TabIndex = 19;
			this.ThrusterMaxPulse.ValueChanged += new System.EventHandler(this.ThrusterMaxPulse_ValueChanged);
			// 
			// DisableThrustBtn
			// 
			this.DisableThrustBtn.Location = new System.Drawing.Point(171, 67);
			this.DisableThrustBtn.Name = "DisableThrustBtn";
			this.DisableThrustBtn.Size = new System.Drawing.Size(66, 23);
			this.DisableThrustBtn.TabIndex = 18;
			this.DisableThrustBtn.Text = "Disable";
			this.DisableThrustBtn.UseVisualStyleBackColor = true;
			this.DisableThrustBtn.Click += new System.EventHandler(this.DisableThrustBtn_Click);
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(6, 21);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(49, 13);
			this.label18.TabIndex = 12;
			this.label18.Text = "Thruster:";
			// 
			// EnableThrustBtn
			// 
			this.EnableThrustBtn.Location = new System.Drawing.Point(170, 43);
			this.EnableThrustBtn.Name = "EnableThrustBtn";
			this.EnableThrustBtn.Size = new System.Drawing.Size(66, 23);
			this.EnableThrustBtn.TabIndex = 17;
			this.EnableThrustBtn.Text = "Enable";
			this.EnableThrustBtn.UseVisualStyleBackColor = true;
			this.EnableThrustBtn.Click += new System.EventHandler(this.EnableThrustBtn_Click);
			// 
			// ThrusterSelector
			// 
			this.ThrusterSelector.FormattingEnabled = true;
			this.ThrusterSelector.Location = new System.Drawing.Point(62, 18);
			this.ThrusterSelector.Name = "ThrusterSelector";
			this.ThrusterSelector.Size = new System.Drawing.Size(158, 21);
			this.ThrusterSelector.TabIndex = 11;
			this.ThrusterSelector.DropDown += new System.EventHandler(this.ThrusterSelector_DropDown);
			this.ThrusterSelector.SelectedIndexChanged += new System.EventHandler(this.ThrusterSelector_SelectedIndexChanged);
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(146, 72);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(18, 13);
			this.label19.TabIndex = 16;
			this.label19.Text = "us";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(4, 48);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(51, 13);
			this.label22.TabIndex = 12;
			this.label22.Text = "Minimum:";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(146, 48);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(18, 13);
			this.label20.TabIndex = 15;
			this.label20.Text = "us";
			// 
			// ThrusterMinPulse
			// 
			this.ThrusterMinPulse.Location = new System.Drawing.Point(62, 46);
			this.ThrusterMinPulse.Name = "ThrusterMinPulse";
			this.ThrusterMinPulse.Size = new System.Drawing.Size(78, 20);
			this.ThrusterMinPulse.TabIndex = 11;
			this.ThrusterMinPulse.ValueChanged += new System.EventHandler(this.ThrusterMinPulse_ValueChanged);
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(4, 72);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(32, 13);
			this.label21.TabIndex = 14;
			this.label21.Text = "Zero:";
			// 
			// ThrusterZeroPulse
			// 
			this.ThrusterZeroPulse.Location = new System.Drawing.Point(62, 71);
			this.ThrusterZeroPulse.Name = "ThrusterZeroPulse";
			this.ThrusterZeroPulse.Size = new System.Drawing.Size(78, 20);
			this.ThrusterZeroPulse.TabIndex = 13;
			this.ThrusterZeroPulse.ValueChanged += new System.EventHandler(this.ThrusterZeroPulse_ValueChanged);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.PortSelector);
			this.groupBox4.Controls.Add(this.label26);
			this.groupBox4.Controls.Add(this.IpTextBox);
			this.groupBox4.Controls.Add(this.label25);
			this.groupBox4.Location = new System.Drawing.Point(308, 145);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(240, 162);
			this.groupBox4.TabIndex = 14;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Ethernet";
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(6, 22);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(23, 13);
			this.label25.TabIndex = 0;
			this.label25.Text = "IP: ";
			// 
			// IpTextBox
			// 
			this.IpTextBox.Location = new System.Drawing.Point(41, 19);
			this.IpTextBox.Name = "IpTextBox";
			this.IpTextBox.Size = new System.Drawing.Size(179, 20);
			this.IpTextBox.TabIndex = 1;
			this.IpTextBox.TextChanged += new System.EventHandler(this.IpTextBox_TextChanged);
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(6, 48);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(29, 13);
			this.label26.TabIndex = 2;
			this.label26.Text = "Port:";
			// 
			// PortSelector
			// 
			this.PortSelector.Location = new System.Drawing.Point(41, 45);
			this.PortSelector.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.PortSelector.Name = "PortSelector";
			this.PortSelector.Size = new System.Drawing.Size(179, 20);
			this.PortSelector.TabIndex = 3;
			this.PortSelector.ValueChanged += new System.EventHandler(this.PortSelector_ValueChanged);
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(566, 349);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "SettingsForm";
			this.Text = "SettingsForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
			this.Load += new System.EventHandler(this.SettingsForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.MaxPulseUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MinPulseUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SpongeOpenPos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MediumOpenPos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SmallOpenPos)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NetClosedPos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NetOpenPos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TinyClosedPos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TinyOpenPos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SmallClosedPos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MediumClosedPos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SpongeClosedPos)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ThrusterMaxPulse)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ThrusterMinPulse)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ThrusterZeroPulse)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PortSelector)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox ServoSelector;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown MaxPulseUpDown;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown MinPulseUpDown;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown SpongeOpenPos;
		private System.Windows.Forms.NumericUpDown MediumOpenPos;
		private System.Windows.Forms.NumericUpDown SmallOpenPos;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button DisableBtn;
		private System.Windows.Forms.Button EnableBtn;
		private System.Windows.Forms.NumericUpDown NetClosedPos;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.NumericUpDown NetOpenPos;
		private System.Windows.Forms.NumericUpDown TinyClosedPos;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.NumericUpDown TinyOpenPos;
		private System.Windows.Forms.NumericUpDown SmallClosedPos;
		private System.Windows.Forms.NumericUpDown MediumClosedPos;
		private System.Windows.Forms.NumericUpDown SpongeClosedPos;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.ComboBox ThrusterSelector;
		private System.Windows.Forms.Button StopThrustBtn;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.NumericUpDown ThrusterMaxPulse;
		private System.Windows.Forms.Button DisableThrustBtn;
		private System.Windows.Forms.Button EnableThrustBtn;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.NumericUpDown ThrusterMinPulse;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.NumericUpDown ThrusterZeroPulse;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.TextBox IpTextBox;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.NumericUpDown PortSelector;
	}
}