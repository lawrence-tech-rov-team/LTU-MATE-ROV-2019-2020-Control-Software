using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTU_MATE_ROV_2019_2020_Control_Software.InputControls {
	public interface IKeyboardListener {

		event KeyEventHandler KeyDown;
		event KeyEventHandler KeyUp;

	}
}
