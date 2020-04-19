using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware;
using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.Ethernet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Simulator {
	public class RobotSimulator : IEthernetLayer {

		private int Latency;
		//private RobotSimulatorUI UI;
		private List<ISimulatorDevice> devices = new List<ISimulatorDevice>();
		private IRegister[] registers = new IRegister[256];
		//private System.Windows.Forms.Timer updateTimer = new System.Windows.Forms.Timer();

		public override bool IsSimulator => true;

		public RobotSimulator(/*RobotSimulatorUI UI, */int latency = 5) {
			//this.UI = UI;
			Latency = latency;
		/*	updateTimer.Interval = 10;
			updateTimer.Tick += UpdateTimer_Tick;
			updateTimer.Start();*/
		}

		//Only to be called from the RobotSimulatorUI
		public void Update() {
			foreach (ISimulatorDevice device in devices) {
				device.Update();
			}
		}
		/*
		private void UpdateTimer_Tick(object sender, EventArgs e) {
			lock (devices) {
				foreach (ISimulatorDevice device in devices) {
					device.Update();
				}
			}
		}*/

		public void RegisterDevice(ISimulatorDevice simDevice) {
			foreach(IRegister register in simDevice) {
				if (registers[register.Id] == null) {
					registers[register.Id] = register;
				} else {
					MessageBox.Show("Simulator ID Collision", "Collision", MessageBoxButtons.OK);
				}
			}
			lock (devices) {
				devices.Add(simDevice);
			}
		}

		public override long? Ping(int timeoutMs = 3000) {
			lock (this) {
				//if (UI != null) {
				if (Connected) { 
					Thread.Sleep(Latency);
					return 5;
				} else {
					return null;
				}
			}
		}

		protected override bool TryConnect() {
			lock (this) {
				//if (UI == null) {
				//	UI = new RobotSimulatorUI(this);
				//	UI.Show();
				//updateTimer.Start();
				return true;
				//} else {
				//	return false;
				//}
			}
		}

		protected override void Close() {
			lock (this) {
				//updateTimer.Stop();
				//if (UI != null) UI?.Invoke(new Action(() => { UI.Close(); }));
				//UI = null;
				//Connected = false;
			}
		}

		protected override bool SendBytes(byte[] bytes) {
			lock (this) {
				if (Connected) {
					UdpPacket response = GetResponse(bytes);
					if (response != null) {
						ThreadPool.QueueUserWorkItem((state) => {
							Thread.Sleep(Latency);
							InvokePacketReceived(response);
						});
						return true;
					}
				}

				return false;
			}
		}

		private UdpPacket GetResponse(byte[] bytes) {
			UdpPacket packet = UdpPacket.ParseData(bytes);
			if (packet != null) {
				byte id = packet.Id; //packet.Data[0];
				if (registers[id] != null) {
					if(registers[id].Update(packet.Data)) {
						byte[] data = registers[id].SendUpdate;
						if (data == null) data = registers[id].ResendUpdate;
						if (data == null) return null;
						return new UdpPacket(id, data);
					}
				}
			}

			return null;
		}

	}
}
