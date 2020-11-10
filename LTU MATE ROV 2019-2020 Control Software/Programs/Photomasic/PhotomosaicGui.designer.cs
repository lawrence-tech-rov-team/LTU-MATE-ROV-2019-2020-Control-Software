namespace PhotoMosaic
{
    partial class PhotomosaicGui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhotomosaicGui));
            this.Side1 = new System.Windows.Forms.PictureBox();
            this.Side2 = new System.Windows.Forms.PictureBox();
            this.Side3 = new System.Windows.Forms.PictureBox();
            this.Side4 = new System.Windows.Forms.PictureBox();
            this.Side0 = new System.Windows.Forms.PictureBox();
            this.LiveFeedBox = new System.Windows.Forms.PictureBox();
            this.FinalBox = new System.Windows.Forms.PictureBox();
            this.StitchButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.TakePhotoButton = new System.Windows.Forms.Button();
            this.BoxL1 = new System.Windows.Forms.Label();
            this.BoxL2 = new System.Windows.Forms.Label();
            this.BoxL3 = new System.Windows.Forms.Label();
            this.BoxL4 = new System.Windows.Forms.Label();
            this.BoxL0 = new System.Windows.Forms.Label();
            this.ThreshBox = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Side1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Side2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Side3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Side4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Side0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiveFeedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThreshBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // Side1
            // 
            this.Side1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Side1.Image = ((System.Drawing.Image)(resources.GetObject("Side1.Image")));
            this.Side1.Location = new System.Drawing.Point(302, 30);
            this.Side1.Name = "Side1";
            this.Side1.Size = new System.Drawing.Size(273, 233);
            this.Side1.TabIndex = 0;
            this.Side1.TabStop = false;
            // 
            // Side2
            // 
            this.Side2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Side2.Image = ((System.Drawing.Image)(resources.GetObject("Side2.Image")));
            this.Side2.Location = new System.Drawing.Point(596, 30);
            this.Side2.Name = "Side2";
            this.Side2.Size = new System.Drawing.Size(273, 233);
            this.Side2.TabIndex = 1;
            this.Side2.TabStop = false;
            // 
            // Side3
            // 
            this.Side3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Side3.Image = ((System.Drawing.Image)(resources.GetObject("Side3.Image")));
            this.Side3.Location = new System.Drawing.Point(890, 30);
            this.Side3.Name = "Side3";
            this.Side3.Size = new System.Drawing.Size(273, 233);
            this.Side3.TabIndex = 2;
            this.Side3.TabStop = false;
            // 
            // Side4
            // 
            this.Side4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Side4.Image = ((System.Drawing.Image)(resources.GetObject("Side4.Image")));
            this.Side4.Location = new System.Drawing.Point(1180, 30);
            this.Side4.Name = "Side4";
            this.Side4.Size = new System.Drawing.Size(273, 233);
            this.Side4.TabIndex = 3;
            this.Side4.TabStop = false;
            // 
            // Side0
            // 
            this.Side0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Side0.Image = ((System.Drawing.Image)(resources.GetObject("Side0.Image")));
            this.Side0.Location = new System.Drawing.Point(12, 30);
            this.Side0.Name = "Side0";
            this.Side0.Size = new System.Drawing.Size(273, 233);
            this.Side0.TabIndex = 4;
            this.Side0.TabStop = false;
            // 
            // LiveFeedBox
            // 
            this.LiveFeedBox.Location = new System.Drawing.Point(403, 392);
            this.LiveFeedBox.Name = "LiveFeedBox";
            this.LiveFeedBox.Size = new System.Drawing.Size(341, 308);
            this.LiveFeedBox.TabIndex = 5;
            this.LiveFeedBox.TabStop = false;
            // 
            // FinalBox
            // 
            this.FinalBox.Image = ((System.Drawing.Image)(resources.GetObject("FinalBox.Image")));
            this.FinalBox.InitialImage = null;
            this.FinalBox.Location = new System.Drawing.Point(1064, 360);
            this.FinalBox.Name = "FinalBox";
            this.FinalBox.Size = new System.Drawing.Size(463, 319);
            this.FinalBox.TabIndex = 6;
            this.FinalBox.TabStop = false;
            // 
            // StitchButton
            // 
            this.StitchButton.Location = new System.Drawing.Point(813, 616);
            this.StitchButton.Name = "StitchButton";
            this.StitchButton.Size = new System.Drawing.Size(144, 52);
            this.StitchButton.TabIndex = 7;
            this.StitchButton.Text = "Stitch";
            this.StitchButton.UseVisualStyleBackColor = true;
            this.StitchButton.Click += new System.EventHandler(this.StitchButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(776, 343);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(109, 52);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.Location = new System.Drawing.Point(891, 343);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(111, 52);
            this.ForwardButton.TabIndex = 9;
            this.ForwardButton.Text = "Forward";
            this.ForwardButton.UseVisualStyleBackColor = true;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // TakePhotoButton
            // 
            this.TakePhotoButton.Location = new System.Drawing.Point(834, 470);
            this.TakePhotoButton.Name = "TakePhotoButton";
            this.TakePhotoButton.Size = new System.Drawing.Size(109, 52);
            this.TakePhotoButton.TabIndex = 11;
            this.TakePhotoButton.Text = "Take Photo";
            this.TakePhotoButton.UseVisualStyleBackColor = true;
            this.TakePhotoButton.Click += new System.EventHandler(this.TakePhotoButton_Click);
            // 
            // BoxL1
            // 
            this.BoxL1.AutoSize = true;
            this.BoxL1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxL1.Location = new System.Drawing.Point(296, 266);
            this.BoxL1.Name = "BoxL1";
            this.BoxL1.Size = new System.Drawing.Size(297, 32);
            this.BoxL1.TabIndex = 12;
            this.BoxL1.Text = "Center Large Side (3)";
            // 
            // BoxL2
            // 
            this.BoxL2.AutoSize = true;
            this.BoxL2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxL2.Location = new System.Drawing.Point(599, 266);
            this.BoxL2.Name = "BoxL2";
            this.BoxL2.Size = new System.Drawing.Size(271, 32);
            this.BoxL2.TabIndex = 13;
            this.BoxL2.Text = "Right Small Side (4)";
            // 
            // BoxL3
            // 
            this.BoxL3.AutoSize = true;
            this.BoxL3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxL3.Location = new System.Drawing.Point(887, 266);
            this.BoxL3.Name = "BoxL3";
            this.BoxL3.Size = new System.Drawing.Size(276, 32);
            this.BoxL3.TabIndex = 14;
            this.BoxL3.Text = "Right Large Side (5)";
            // 
            // BoxL4
            // 
            this.BoxL4.AutoSize = true;
            this.BoxL4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxL4.Location = new System.Drawing.Point(1191, 266);
            this.BoxL4.Name = "BoxL4";
            this.BoxL4.Size = new System.Drawing.Size(253, 32);
            this.BoxL4.TabIndex = 15;
            this.BoxL4.Text = "Left Small Side (2)";
            // 
            // BoxL0
            // 
            this.BoxL0.AutoSize = true;
            this.BoxL0.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxL0.Location = new System.Drawing.Point(102, 266);
            this.BoxL0.Name = "BoxL0";
            this.BoxL0.Size = new System.Drawing.Size(108, 32);
            this.BoxL0.TabIndex = 16;
            this.BoxL0.Text = "Top (1)";
            // 
            // ThreshBox
            // 
            this.ThreshBox.Location = new System.Drawing.Point(12, 392);
            this.ThreshBox.Name = "ThreshBox";
            this.ThreshBox.Size = new System.Drawing.Size(341, 308);
            this.ThreshBox.TabIndex = 17;
            this.ThreshBox.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 301);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(307, 45);
            this.trackBar1.TabIndex = 18;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(12, 343);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(307, 45);
            this.trackBar2.TabIndex = 19;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(325, 301);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(325, 343);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 21;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 712);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.ThreshBox);
            this.Controls.Add(this.BoxL0);
            this.Controls.Add(this.BoxL4);
            this.Controls.Add(this.BoxL3);
            this.Controls.Add(this.BoxL2);
            this.Controls.Add(this.BoxL1);
            this.Controls.Add(this.TakePhotoButton);
            this.Controls.Add(this.ForwardButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.StitchButton);
            this.Controls.Add(this.FinalBox);
            this.Controls.Add(this.LiveFeedBox);
            this.Controls.Add(this.Side0);
            this.Controls.Add(this.Side4);
            this.Controls.Add(this.Side3);
            this.Controls.Add(this.Side2);
            this.Controls.Add(this.Side1);
            this.Name = "Form1";
            this.Text = "Photomosaic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Side1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Side2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Side3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Side4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Side0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiveFeedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThreshBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Side1;
        private System.Windows.Forms.PictureBox Side2;
        private System.Windows.Forms.PictureBox Side3;
        private System.Windows.Forms.PictureBox Side4;
        private System.Windows.Forms.PictureBox Side0;
        private System.Windows.Forms.PictureBox LiveFeedBox;
        private System.Windows.Forms.PictureBox FinalBox;
        private System.Windows.Forms.Button StitchButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button TakePhotoButton;
        private System.Windows.Forms.Label BoxL1;
        private System.Windows.Forms.Label BoxL2;
        private System.Windows.Forms.Label BoxL3;
        private System.Windows.Forms.Label BoxL4;
        private System.Windows.Forms.Label BoxL0;
        private System.Windows.Forms.PictureBox ThreshBox;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

