using JoystickInput;
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
	public partial class MainInterface : Form {

		public MainInterface() {
			InitializeComponent();
		}

		private void MainInterface_Load(object sender, EventArgs e) {
			
		}

		private void ControlsMenu_Click(object sender, EventArgs e) {
			
		}

		private void KeyboardMenu_Click(object sender, EventArgs e) {
			new KeyboardConfigForm().ShowDialog();
		}

		private void JoystickMenu_Click(object sender, EventArgs e) {
			new JoystickConfigForm().ShowDialog();
		}

	}
}
