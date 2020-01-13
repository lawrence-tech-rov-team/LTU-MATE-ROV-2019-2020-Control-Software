using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Ethernet {
	public enum Command : byte {
		Ping = 0,
		Echo = 1,
		Led = 2
	}
}
