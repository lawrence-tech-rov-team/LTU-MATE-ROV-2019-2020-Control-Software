using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware.Ethernet {
	public class EthernetInterface {

		public int DestinationPort { get; } = 6001;
		public int ReceivePort { get; } = 6002;
		public string TargetIp { get; set; } = "169.254.240.157"; //255.255.255.255
		private volatile bool connected = false;
		public bool Connected { get => connected; private set => connected = value; }

		private UdpClient client;
		private Random random = new Random();

		public delegate void NewPacketHandler(UdpPacket packet);
		public event NewPacketHandler OnPacketReceived;

		public EthernetInterface() {

		}

		~EthernetInterface() {
			Disconnect();
		}

		private bool AutoConnect() {
			int origSendTimeout = 5000;
			int origRecvTimeout = 5000;

			try {
				origSendTimeout = client.Client.SendTimeout;
				origRecvTimeout = client.Client.ReceiveTimeout;

				client.Client.SendTimeout = 100;
				client.Client.ReceiveTimeout = 100;
			} catch (Exception ex) { }

			IPEndPoint ip = new IPEndPoint(IPAddress.Any, ReceivePort);
			byte[] pings = new byte[10];
			random.NextBytes(pings);
			int counts = 0;
			for (int i = 0; i < 10; i++) {
				try {
					Console.Out.WriteLine("Attempt #{0}...", i);
					UdpPacket packet = new UdpPacket(Command.Ping, pings[i]);
					byte[] data = packet.AllBytes;
					client.Send(data, data.Length, TargetIp, DestinationPort);
					data = client.Receive(ref ip);
					packet = UdpPacket.ParseData(data);
					if ((packet != null) && (packet.Command == Command.Ping) && (packet.Data.Length == 1) && (packet.Data[0] == pings[i])) {
						counts++;
					}
				} catch (Exception ex) {
					Console.Error.WriteLine("Error sending/receiving packet: {0}", ex.Message);
					Console.Error.WriteLine(ex.StackTrace);
				}
			}

			try {
				client.Client.SendTimeout = origSendTimeout;
				client.Client.ReceiveTimeout = origRecvTimeout;
			} catch (Exception ex) { }

			Console.WriteLine("Counts: {0}", counts);

			return counts >= 5; //TODO try up to ten times, but if one suceeds then it will try five times, not counting towards the ten
		}

		public bool TryConnect() {
			lock (this) {
				Disconnect();

				try {
					client = new UdpClient();
					client.Client.Bind(new IPEndPoint(IPAddress.Any, ReceivePort));
					bool success = AutoConnect();
					//client.Connect(new IPEndPoint(IPAddress.Any, ReceivePort));
					/*int origSend = client.Client.SendTimeout;
					int origRecv = client.Client.ReceiveTimeout;
					client.Client.SendTimeout = client.Client.ReceiveTimeout = 1000;
					bool success = false;
					try {
						IPEndPoint ip = new IPEndPoint(IPAddress.Any, ReceivePort);
						byte[] pings = new byte[10];
						random.NextBytes(pings);
						int counts = 0;
						for (int i = 0; i < 10; i++) {
							Console.Out.WriteLine("Attempt #{0}...", i);
							UdpPacket packet = new UdpPacket(Command.Ping, pings[i]);
							byte[] data = packet.AllBytes;
							client.Send(data, data.Length, TargetIp, DestinationPort);
							try {
								data = client.Receive(ref ip);
							} catch (SocketException) { }
							packet = UdpPacket.ParseData(data);
							if((packet != null) && (packet.Command == Command.Ping) && (packet.Data != null) && (packet.Data.Length >= 1) && (packet.Data[0] == pings[0])) {
								counts++;
								if (counts >= 3) break;
							}
						}
						if (counts >= 3) success = true;
					} catch (Exception ex2) {
						Console.Error.WriteLine("Error trying to connect: {0}", ex2.Message);
						Console.Error.WriteLine(ex2.StackTrace);
						success = false;
					}

					client.Client.SendTimeout = origSend;
					client.Client.ReceiveTimeout = origRecv;*/
					if (success) {
						client.BeginReceive(new AsyncCallback(OnDataReceived), null);
						Connected = true;
					}
					return success;
				} catch (Exception ex) {
					Disconnect();

					Console.Error.WriteLine("Could not connect to IP: {0}", ex.Message);
					Console.Error.WriteLine(ex.StackTrace);
					return false;
				}
			}
		}

		public void Disconnect() {
			lock (this) {
				Connected = false;
				try {
					if (client != null) client.Close();
				} catch (SocketException e) {
					//TODO exception thrown
				}
				//TODO callback on close.
			}
		}

		public bool Send(UdpPacket packet) {
			try { //TODO an option in logger to log all bytes sent and received.
				lock (this) {
					if (Connected) {
						byte[] data = packet.AllBytes;
						client.Send(data, data.Length, TargetIp, DestinationPort);
					}
				}
				return true;
			} catch (Exception ex) {
				Console.Error.WriteLine("Error sending packet: {0}", ex.Message);
				Console.Error.WriteLine(ex.StackTrace);
				return false;
			}
		}

		public bool Send(Command command, ByteArray data) {
			return Send(new UdpPacket(command, data));
		}

		public bool Send(Command command, params byte[] data) {
			return Send(new UdpPacket(command, data));
		}

		public bool Send(Command command, string message, bool clip = true) {
			if (clip || (message.Length <= UdpPacket.MAX_LENGTH))
				return Send(new UdpPacket(command, Encoding.UTF8.GetBytes(message)));
			else {
				bool result = Send(new UdpPacket(command, Encoding.UTF8.GetBytes(message.Substring(0, UdpPacket.MAX_LENGTH))));
				if (!result) return false;
				return Send(command, message.Substring(UdpPacket.MAX_LENGTH), clip);
			}
		}

		private void OnDataReceived(IAsyncResult res) {
			try {
				lock (this) { //TODO only lock what is necessary. Don't lock the callback function
					IPEndPoint ip = new IPEndPoint(IPAddress.Any, ReceivePort);
					byte[] data = client.EndReceive(res, ref ip);
					UdpPacket packet = UdpPacket.ParseData(data);
					if (packet != null) OnPacketReceived?.Invoke(packet); //TODO don't catch exception for called function.
					else Console.Out.WriteLine("Bad packet received."); //TODO logger
					client.BeginReceive(new AsyncCallback(OnDataReceived), null);
				}
			} catch (Exception e) {
				Disconnect();
			}
		}

		public long? PingHardware(int timeoutMs = 3000) {
			long? time = null;
			Ping pinger = null;

			try {
				pinger = new Ping();
				PingReply reply = pinger.Send(TargetIp, timeoutMs);

				if (reply.Status == IPStatus.Success) {
					time = reply.RoundtripTime;
				}
			} catch (Exception) {
				// Discard PingExceptions and return false;
			} finally {
				if (pinger != null) {
					pinger.Dispose();
				}
			}

			return time;
		}
	}
}
