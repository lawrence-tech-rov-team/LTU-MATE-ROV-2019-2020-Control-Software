using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.DataTypes;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware {

	public abstract class IDevice : IEnumerable<IRegister>{

		public abstract IRegister[] Registers { get; }

		public IEnumerator<IRegister> GetEnumerator() {
			return Registers.AsEnumerable().GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator() {
			return Registers.GetEnumerator();
		}
	}

}
