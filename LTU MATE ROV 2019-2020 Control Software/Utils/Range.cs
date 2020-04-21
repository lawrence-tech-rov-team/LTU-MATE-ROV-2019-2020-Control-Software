using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Utils {
	public struct Range {

		public ushort Minimum;
		public ushort Maximum;

		public Range(ushort Min, ushort Max) {
			Minimum = Min;
			Maximum = Max;
		}

		/// <summary>
		/// Limits the given value to the range.
		/// If Minimum > Maximum, then the maximum will be treated as the minimum and the minimum the maximum.
		/// </summary>
		public ushort Limit(ushort value) {
			if(Minimum <= Maximum) {
				if (value < Minimum) return Minimum;
				else if (value > Maximum) return Maximum;
				else return value;
			} else {
				if (value < Maximum) return Maximum;
				else if (value > Minimum) return Minimum;
				else return value;
			}
		}

		/// <summary>
		/// Interpolates between the minimum and maximum, where if value less or equal to 0 then Minimum is returned,
		/// and if value greater or equal to 1 then Maximum is returned. 
		/// </summary>
		public ushort Interpolate (float value) {
			if (value <= 0f) return Minimum;
			else if (value >= 1f) return Maximum;
			else return (ushort)((int)Math.Round(((int)Maximum - (int)Minimum) * value) + Minimum);
		}

		/// <summary>
		/// Estimates the percentage of the range from [0, 1].
		/// I.e. is value is less than or equal to Minimum, 0 is returned.
		/// If value is greater than or equal to Maximum, 1 is returned.
		/// A fraction is returned as a linear interpolation between the two.
		/// 
		/// If minimum is greater than maximum, then 0 is still located at minimum
		/// but the check changes to 'if value is greater than or equal to minimum'.
		/// Same for the maximum.
		/// 
		/// If minimum and maximum are the same, 0f will be returned.
		/// </summary>
		public float Interpolate(ushort value) {
			if (Minimum == Maximum) return 0f;

			if(Minimum <= Maximum) {
				if (value <= Minimum) return 0f;
				else if (value >= Maximum) return 1f;
			} else {
				if (value >= Minimum) return 0f;
				else if (value <= Maximum) return 1f;
			}

			return (float)(value - Minimum) / (float)(Maximum - Minimum);
		}

	}
}
