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
			this.SuspendLayout();
			// 
			// ServoSelector
			// 
			this.ServoSelector.FormattingEnabled = true;
			this.ServoSelector.Location = new System.Drawing.Point(83, 23);
			this.ServoSelector.Margin = new System.Windows.Forms.Padding(4);
			this.ServoSelector.Name = "ServoSelector";
			this.ServoSelector.Size = new System.Drawing.Size(219, 24);
			this.ServoSelector.TabIndex = 0;
			this.ServoSelector.DropDown += new System.EventHandler(this.ServoSelector_DropDown);
			this.ServoSelector.SelectedIndexChanged += new System.EventHandler(this.ServoSelector_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 27);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 17);
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
			this.groupBox1.Location = new System.Drawing.Point(16, 15);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(387, 156);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Servo Calibration";
			// 
			// DisableBtn
			// 
			this.DisableBtn.Location = new System.Drawing.Point(229, 85);
			this.DisableBtn.Margin = new System.Windows.Forms.Padding(4);
			this.DisableBtn.Name = "DisableBtn";
			this.DisableBtn.Size = new System.Drawing.Size(88, 28);
			this.DisableBtn.TabIndex = 10;
			this.DisableBtn.Text = "Disable";
			this.DisableBtn.UseVisualStyleBackColor = true;
			this.DisableBtn.Click += new System.EventHandler(this.DisableBtn_Click);
			// 
			// EnableBtn
			// 
			this.EnableBtn.Location = new System.Drawing.Point(229, 53);
			this.EnableBtn.Margin = new System.Windows.Forms.Padding(4);
			this.EnableBtn.Name = "EnableBtn";
			this.EnableBtn.Size = new System.Drawing.Size(88, 28);
			this.EnableBtn.TabIndex = 9;
			this.EnableBtn.Text = "Enable";
			this.EnableBtn.UseVisualStyleBackColor = true;
			this.EnableBtn.Click += new System.EventHandler(this.EnableBtn_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(196, 91);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(23, 17);
			this.label8.TabIndex = 8;
			this.label8.Text = "us";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(196, 59);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(23, 17);
			this.label7.TabIndex = 7;
			this.label7.Text = "us";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 91);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "Maximum:";
			// 
			// MaxPulseUpDown
			// 
			this.MaxPulseUpDown.Location = new System.Drawing.Point(84, 89);
			this.MaxPulseUpDown.Margin = new System.Windows.Forms.Padding(4);
			this.MaxPulseUpDown.Name = "MaxPulseUpDown";
			this.MaxPulseUpDown.Size = new System.Drawing.Size(104, 22);
			this.MaxPulseUpDown.TabIndex = 5;
			this.MaxPulseUpDown.ValueChanged += new System.EventHandler(this.MaxPulseUpDown_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 59);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "Minimum:";
			// 
			// MinPulseUpDown
			// 
			this.MinPulseUpDown.Location = new System.Drawing.Point(84, 57);
			this.MinPulseUpDown.Margin = new System.Windows.Forms.Padding(4);
			this.MinPulseUpDown.Name = "MinPulseUpDown";
			this.MinPulseUpDown.Size = new System.Drawing.Size(104, 22);
			this.MinPulseUpDown.TabIndex = 3;
			this.MinPulseUpDown.ValueChanged += new System.EventHandler(this.MinPulseUpDown_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 42);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Sponge:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 74);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 17);
			this.label5.TabIndex = 4;
			this.label5.Text = "Medium:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 106);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(46, 17);
			this.label6.TabIndex = 5;
			this.label6.Text = "Small:";
			// 
			// SpongeOpenPos
			// 
			this.SpongeOpenPos.Location = new System.Drawing.Point(83, 39);
			this.SpongeOpenPos.Margin = new System.Windows.Forms.Padding(4);
			this.SpongeOpenPos.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
			this.SpongeOpenPos.Name = "SpongeOpenPos";
			this.SpongeOpenPos.Size = new System.Drawing.Size(105, 22);
			this.SpongeOpenPos.TabIndex = 6;
			this.SpongeOpenPos.ValueChanged += new System.EventHandler(this.SpongeOpenPos_ValueChanged);
			// 
			// MediumOpenPos
			// 
			this.MediumOpenPos.Location = new System.Drawing.Point(83, 71);
			this.MediumOpenPos.Margin = new System.Windows.Forms.Padding(4);
			this.MediumOpenPos.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
			this.MediumOpenPos.Name = "MediumOpenPos";
			this.MediumOpenPos.Size = new System.Drawing.Size(105, 22);
			this.MediumOpenPos.TabIndex = 7;
			this.MediumOpenPos.ValueChanged += new System.EventHandler(this.MediumOpenPos_ValueChanged);
			// 
			// SmallOpenPos
			// 
			this.SmallOpenPos.Location = new System.Drawing.Point(83, 103);
			this.SmallOpenPos.Margin = new System.Windows.Forms.Padding(4);
			this.SmallOpenPos.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
			this.SmallOpenPos.Name = "SmallOpenPos";
			this.SmallOpenPos.Size = new System.Drawing.Size(105, 22);
			this.SmallOpenPos.TabIndex = 8;
			this.SmallOpenPos.ValueChanged += new System.EventHandler(this.SmallOpenPos_ValueChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(311, 106);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(62, 17);
			this.label9.TabIndex = 9;
			this.label9.Text = "Degrees";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(311, 42);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(62, 17);
			this.label10.TabIndex = 10;
			this.label10.Text = "Degrees";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(311, 74);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(62, 17);
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
			this.groupBox2.Location = new System.Drawing.Point(16, 179);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(387, 199);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Gripper Positions";
			// 
			// NetClosedPos
			// 
			this.NetClosedPos.Location = new System.Drawing.Point(197, 164);
			this.NetClosedPos.Margin = new System.Windows.Forms.Padding(4);
			this.NetClosedPos.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
			this.NetClosedPos.Name = "NetClosedPos";
			this.NetClosedPos.Size = new System.Drawing.Size(105, 22);
			this.NetClosedPos.TabIndex = 24;
			this.NetClosedPos.ValueChanged += new System.EventHandler(this.NetClosedPos_ValueChanged);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(311, 166);
			this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(62, 17);
			this.label17.TabIndex = 23;
			this.label17.Text = "Degrees";
			// 
			// NetOpenPos
			// 
			this.NetOpenPos.Location = new System.Drawing.Point(83, 164);
			this.NetOpenPos.Margin = new System.Windows.Forms.Padding(4);
			this.NetOpenPos.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
			this.NetOpenPos.Name = "NetOpenPos";
			this.NetOpenPos.Size = new System.Drawing.Size(105, 22);
			this.NetOpenPos.TabIndex = 22;
			this.NetOpenPos.ValueChanged += new System.EventHandler(this.NetOpenPos_ValueChanged);
			// 
			// TinyClosedPos
			// 
			this.TinyClosedPos.Location = new System.Drawing.Point(197, 134);
			this.TinyClosedPos.Margin = new System.Windows.Forms.Padding(4);
			this.TinyClosedPos.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
			this.TinyClosedPos.Name = "TinyClosedPos";
			this.TinyClosedPos.Size = new System.Drawing.Size(105, 22);
			this.TinyClosedPos.TabIndex = 21;
			this.TinyClosedPos.ValueChanged += new System.EventHandler(this.TinyClosedPos_ValueChanged);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(311, 135);
			this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(62, 17);
			this.label16.TabIndex = 20;
			this.label16.Text = "Degrees";
			// 
			// TinyOpenPos
			// 
			this.TinyOpenPos.Location = new System.Drawing.Point(83, 134);
			this.TinyOpenPos.Margin = new System.Windows.Forms.Padding(4);
			this.TinyOpenPos.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
			this.TinyOpenPos.Name = "TinyOpenPos";
			this.TinyOpenPos.Size = new System.Drawing.Size(105, 22);
			this.TinyOpenPos.TabIndex = 19;
			this.TinyOpenPos.ValueChanged += new System.EventHandler(this.TinyOpenPos_ValueChanged);
			// 
			// SmallClosedPos
			// 
			this.SmallClosedPos.Location = new System.Drawing.Point(197, 103);
			this.SmallClosedPos.Margin = new System.Windows.Forms.Padding(4);
			this.SmallClosedPos.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
			this.SmallClosedPos.Name = "SmallClosedPos";
			this.SmallClosedPos.Size = new System.Drawing.Size(105, 22);
			this.SmallClosedPos.TabIndex = 18;
			this.SmallClosedPos.ValueChanged += new System.EventHandler(this.SmallClosedPos_ValueChanged);
			// 
			// MediumClosedPos
			// 
			this.MediumClosedPos.Location = new System.Drawing.Point(197, 71);
			this.MediumClosedPos.Margin = new System.Windows.Forms.Padding(4);
			this.MediumClosedPos.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
			this.MediumClosedPos.Name = "MediumClosedPos";
			this.MediumClosedPos.Size = new System.Drawing.Size(105, 22);
			this.MediumClosedPos.TabIndex = 17;
			this.MediumClosedPos.ValueChanged += new System.EventHandler(this.MediumClosedPos_ValueChanged);
			// 
			// SpongeClosedPos
			// 
			this.SpongeClosedPos.Location = new System.Drawing.Point(197, 39);
			this.SpongeClosedPos.Margin = new System.Windows.Forms.Padding(4);
			this.SpongeClosedPos.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
			this.SpongeClosedPos.Name = "SpongeClosedPos";
			this.SpongeClosedPos.Size = new System.Drawing.Size(105, 22);
			this.SpongeClosedPos.TabIndex = 16;
			this.SpongeClosedPos.ValueChanged += new System.EventHandler(this.SpongeClosedPos_ValueChanged);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(227, 18);
			this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(51, 17);
			this.label15.TabIndex = 15;
			this.label15.Text = "Closed";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(113, 18);
			this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(43, 17);
			this.label14.TabIndex = 14;
			this.label14.Text = "Open";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(8, 166);
			this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(34, 17);
			this.label13.TabIndex = 13;
			this.label13.Text = "Net:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(8, 135);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(39, 17);
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
			this.groupBox3.Location = new System.Drawing.Point(410, 15);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(320, 156);
			this.groupBox3.TabIndex = 13;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Thruster Calibration";
			// 
			// StopThrustBtn
			// 
			this.StopThrustBtn.Location = new System.Drawing.Point(228, 113);
			this.StopThrustBtn.Margin = new System.Windows.Forms.Padding(4);
			this.StopThrustBtn.Name = "StopThrustBtn";
			this.StopThrustBtn.Size = new System.Drawing.Size(88, 28);
			this.StopThrustBtn.TabIndex = 22;
			this.StopThrustBtn.Text = "Stop";
			this.StopThrustBtn.UseVisualStyleBackColor = true;
			this.StopThrustBtn.Click += new System.EventHandler(this.StopThrustBtn_Click);
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(194, 119);
			this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(23, 17);
			this.label23.TabIndex = 21;
			this.label23.Text = "us";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(6, 119);
			this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(70, 17);
			this.label24.TabIndex = 20;
			this.label24.Text = "Maximum:";
			// 
			// ThrusterMaxPulse
			// 
			this.ThrusterMaxPulse.Location = new System.Drawing.Point(82, 117);
			this.ThrusterMaxPulse.Margin = new System.Windows.Forms.Padding(4);
			this.ThrusterMaxPulse.Name = "ThrusterMaxPulse";
			this.ThrusterMaxPulse.Size = new System.Drawing.Size(104, 22);
			this.ThrusterMaxPulse.TabIndex = 19;
			this.ThrusterMaxPulse.ValueChanged += new System.EventHandler(this.ThrusterMaxPulse_ValueChanged);
			// 
			// DisableThrustBtn
			// 
			this.DisableThrustBtn.Location = new System.Drawing.Point(228, 83);
			this.DisableThrustBtn.Margin = new System.Windows.Forms.Padding(4);
			this.DisableThrustBtn.Name = "DisableThrustBtn";
			this.DisableThrustBtn.Size = new System.Drawing.Size(88, 28);
			this.DisableThrustBtn.TabIndex = 18;
			this.DisableThrustBtn.Text = "Disable";
			this.DisableThrustBtn.UseVisualStyleBackColor = true;
			this.DisableThrustBtn.Click += new System.EventHandler(this.DisableThrustBtn_Click);
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(8, 26);
			this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(66, 17);
			this.label18.TabIndex = 12;
			this.label18.Text = "Thruster:";
			// 
			// EnableThrustBtn
			// 
			this.EnableThrustBtn.Location = new System.Drawing.Point(227, 53);
			this.EnableThrustBtn.Margin = new System.Windows.Forms.Padding(4);
			this.EnableThrustBtn.Name = "EnableThrustBtn";
			this.EnableThrustBtn.Size = new System.Drawing.Size(88, 28);
			this.EnableThrustBtn.TabIndex = 17;
			this.EnableThrustBtn.Text = "Enable";
			this.EnableThrustBtn.UseVisualStyleBackColor = true;
			this.EnableThrustBtn.Click += new System.EventHandler(this.EnableThrustBtn_Click);
			// 
			// ThrusterSelector
			// 
			this.ThrusterSelector.FormattingEnabled = true;
			this.ThrusterSelector.Location = new System.Drawing.Point(83, 22);
			this.ThrusterSelector.Margin = new System.Windows.Forms.Padding(4);
			this.ThrusterSelector.Name = "ThrusterSelector";
			this.ThrusterSelector.Size = new System.Drawing.Size(209, 24);
			this.ThrusterSelector.TabIndex = 11;
			this.ThrusterSelector.DropDown += new System.EventHandler(this.ThrusterSelector_DropDown);
			this.ThrusterSelector.SelectedIndexChanged += new System.EventHandler(this.ThrusterSelector_SelectedIndexChanged);
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(194, 89);
			this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(23, 17);
			this.label19.TabIndex = 16;
			this.label19.Text = "us";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(6, 59);
			this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(67, 17);
			this.label22.TabIndex = 12;
			this.label22.Text = "Minimum:";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(194, 59);
			this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(23, 17);
			this.label20.TabIndex = 15;
			this.label20.Text = "us";
			// 
			// ThrusterMinPulse
			// 
			this.ThrusterMinPulse.Location = new System.Drawing.Point(82, 57);
			this.ThrusterMinPulse.Margin = new System.Windows.Forms.Padding(4);
			this.ThrusterMinPulse.Name = "ThrusterMinPulse";
			this.ThrusterMinPulse.Size = new System.Drawing.Size(104, 22);
			this.ThrusterMinPulse.TabIndex = 11;
			this.ThrusterMinPulse.ValueChanged += new System.EventHandler(this.ThrusterMinPulse_ValueChanged);
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(6, 89);
			this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(42, 17);
			this.label21.TabIndex = 14;
			this.label21.Text = "Zero:";
			// 
			// ThrusterZeroPulse
			// 
			this.ThrusterZeroPulse.Location = new System.Drawing.Point(82, 87);
			this.ThrusterZeroPulse.Margin = new System.Windows.Forms.Padding(4);
			this.ThrusterZeroPulse.Name = "ThrusterZeroPulse";
			this.ThrusterZeroPulse.Size = new System.Drawing.Size(104, 22);
			this.ThrusterZeroPulse.TabIndex = 13;
			this.ThrusterZeroPulse.ValueChanged += new System.EventHandler(this.ThrusterZeroPulse_ValueChanged);
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(755, 430);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(4);
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
	}
}