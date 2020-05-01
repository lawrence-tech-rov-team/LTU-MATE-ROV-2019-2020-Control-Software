using JsonSerializable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Utils {
	public struct MidpointRange : IJsonSerializable {

		public ushort Minimum;
		public ushort Midpoint;
		public ushort Maximum;

		public MidpointRange(ushort Min, ushort Mid, ushort Max) {
			Minimum = Min;
			Midpoint = Mid;
			Maximum = Max;
		}

		/// <summary>
		/// Limits the given value to the range.
		/// If Minimum > Maximum, then the maximum will be treated as the minimum and the minimum the maximum.
		/// </summary>
		public ushort Limit(ushort value) {
			if (Minimum <= Maximum) {
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
		/// Interpolates between the minimum and maximum, where if value less or equal to -1 then Minimum is returned,
		/// if value is 0f midpoint is returned, and if value greater or equal to 1 then Maximum is returned. 
		/// </summary>
		public ushort Interpolate(float value) {
			if (value <= -1f) return Minimum;
			else if (value >= 1f) return Maximum;

			if(value >= 0f) {
				return (ushort)((int)Math.Round(((int)Maximum - (int)Midpoint) * value) + Midpoint);
			} else {
				return (ushort)((int)Math.Round(((int)Minimum - (int)Midpoint) * value) + Minimum); //Minimum-Midpoint to take negative value into account
			}
		}

		public JsonData SaveToJson() {
			JsonObject obj = new JsonObject();
			obj["Minimum"] = new JsonInteger(Minimum);
			obj["Midpoint"] = new JsonInteger(Midpoint);
			obj["Maximum"] = new JsonInteger(Maximum);
			return obj;
		}

		public bool LoadFromJson(JsonData Data) {
			if ((Data != null) && (Data is JsonObject obj)) {
				JsonData data = obj["Minimum"];
				if ((data != null) && (data is JsonInteger minData)) {
					Minimum = (ushort)Math.Max(ushort.MinValue, Math.Min(ushort.MaxValue, minData));
					data = obj["Midpoint"];
					if((data != null) && (data is JsonInteger midData)) {
						Midpoint = (ushort)Math.Max(ushort.MinValue, Math.Min(ushort.MaxValue, midData));
						data = obj["Maximum"];
						if ((data != null) && (data is JsonInteger maxData)) {
							Maximum = (ushort)Math.Max(ushort.MinValue, Math.Min(ushort.MaxValue, maxData));
							return true;
						}
					}
				}
			}
			return false;
		}
	}
}
