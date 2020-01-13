using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Utils {
	public static class EnumUtil {

		public static IEnumerable<T> GetValues<T>() {
			return Enum.GetValues(typeof(T)).Cast<T>();
		}

	}
}
