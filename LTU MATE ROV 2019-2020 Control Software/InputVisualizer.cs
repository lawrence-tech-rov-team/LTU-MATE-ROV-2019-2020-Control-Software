using LTU_MATE_ROV_2019_2020_Control_Software.InputControls;
using LTU_MATE_ROV_2019_2020_Control_Software.InputControls.Keyboard;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
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
	public partial class InputVisualizer : Form, IKeyboardListener {

		private InputThread input;

		public InputVisualizer(InputThread input) {
			this.input = input;
			InitializeComponent();
		}

		private void InputVisualizer_Load(object sender, EventArgs e) {
			timer1.Start();
		}

		private void timer1_Tick(object sender, EventArgs e) {
			Twist twist = input?.Input ?? new Twist();
			LinearX.Value = (decimal)twist.Linear.X;
			LinearY.Value = (decimal)twist.Linear.Y;
			LinearZ.Value = (decimal)twist.Linear.Z;
		}
	}
}
