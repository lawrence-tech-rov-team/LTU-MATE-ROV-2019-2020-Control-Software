using JsonSerializable;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Settings {
	public abstract class IRovState : IJsonSerializable {



	}

	public class ServoState : IJsonSerializable {

		public ushort Pulse { get; }
		public bool Enable { get; }
		public Range PulseRange { get; }

		public bool LoadFromJson(JsonData Data) {
			throw new NotImplementedException();
		}

		public JsonData SaveToJson() {
			JsonObject obj = new JsonObject();
			obj["Pulse"] = new JsonInteger(Pulse);
			obj["Enable"] = new JsonBool(Enable);
			obj["Pulse Range"] = PulseRange.SaveToJson();
			return obj;
		}
	}

}
