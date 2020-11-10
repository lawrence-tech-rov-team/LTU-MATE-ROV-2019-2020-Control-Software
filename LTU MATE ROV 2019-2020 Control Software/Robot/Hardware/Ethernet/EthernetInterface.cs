using CustomLogger;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using onvif10_receiver;
using Ozeki.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.Ethernet {
	public class EthernetInterface : IEthernetLayer{

		public int HostPort { get; private set; }
		//public int ReceivePort { get; private set; }
		public IPAddress TargetIp { get; }// = "169.254.240.157"; //255.255.255.255
		public int DestinationPort { get; } //= 6001;

		public override bool IsSimulator => false;

		//private volatile bool connected = false;
		//public bool Connected { get => connected; private set => connected = value; }

		private UdpClient client;
		//private IPEndPoint ReceiverIP;
		private IPEndPoint DestinationIP;
		private Random random = new Random();

		//public delegate void NewPacketHandler(UdpPacket packet);
		//public event NewPacketHandler OnPacketReceived;

		public EthernetInterface(IPAddress DestinationIP, int DestinationPort, int HostPort = 0) {
			TargetIp = DestinationIP;
			this.DestinationPort = DestinationPort;
			this.HostPort = /*this.ReceivePort =*/ HostPort;
		}
		/*
		public EthernetInterface(IPAddress DestinationIP, int DestinationPort, int HostPort, int ReceiverPort) {
			TargetIp = DestinationIP;
			this.DestinationPort = DestinationPort;
			this.HostPort = HostPort;
			this.ReceivePort = ReceiverPort;
		}
		*/
		/*
		~EthernetInterface() {
			Disconnect();
		}*/

		private bool AutoConnect() {
			int origSendTimeout = 5000;
			int origRecvTimeout = 5000;

			try {
				origSendTimeout = client.Client.SendTimeout;
				origRecvTimeout = client.Client.ReceiveTimeout;

				client.Client.SendTimeout = 100;
				client.Client.ReceiveTimeout = 100;
			} catch (Exception) { }

			//IPEndPoint ip = new IPEndPoint(TargetIp, ReceivePort);
			byte[] pings = new byte[10];
			random.NextBytes(pings);
			int counts = 0;
			for (int i = 0; i < 10; i++) {
				try {
					Console.Out.WriteLine("Attempt #{0}...", i);

					/*UdpPacket packet = new UdpPacket(Command.Ping, pings[i]);
					byte[] data = packet.AllBytes;
					client.Send(data, data.Length, TargetIp, DestinationPort);
					data = client.Receive(ref ip);
					packet = UdpPacket.ParseData(data);
					if ((packet != null) && (packet.Command == Command.Ping) && (packet.Data.Length == 1) && (packet.Data[0] == pings[i])) {
					*/
					if (Ping(200) != null) { 
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
			} catch (Exception) { }

			Console.WriteLine("Counts: {0}", counts);

			return counts >= 5;
		}

		protected override bool TryConnect() {
			lock (this) {
				try {
					client = new UdpClient(HostPort);
					DestinationIP = new IPEndPoint(TargetIp, DestinationPort);
					//ReceiverIP = new IPEndPoint(TargetIp, client.port);
					//client.Client.Bind(ReceiverIP);
					bool success = AutoConnect();
					if (success) {
						client.BeginReceive(new AsyncCallback(OnDataReceived), null);
					}
					return success;
				} catch (Exception ex) {
					Console.Error.WriteLine("Could not connect to IP: {0}", ex.Message);
					Console.Error.WriteLine(ex.StackTrace);
					return false;
				}
			}
		}

		protected override void Close() {
			lock (this) {
				try {
					if (client != null) client.Close();
				} catch (SocketException) {
					
				}
			}
		}

		protected override bool SendBytes(byte[] bytes) {
			try {
				client.Send(bytes, bytes.Length, DestinationIP);
				return true;
			} catch (Exception ex) {
				Log.Error("Error sending packet: " + ex.Message); //Console.Error.WriteLine("Error sending packet: {0}", ex.Message);
				Log.Debug(ex.StackTrace); //Console.Error.WriteLine(ex.StackTrace);
				return false;
			}
		}

		private void OnDataReceived(IAsyncResult res) {
			try {
				byte[] data = null;
				lock (this) { 
					data = client.EndReceive(res, ref DestinationIP);
					client.BeginReceive(new AsyncCallback(OnDataReceived), null);
				}

				UdpPacket packet = UdpPacket.ParseData(data);
				if (packet != null) {
					try {
						Log.Debug("Valid packet received: " + packet.Id);
						InvokePacketReceived(packet);
					} catch (Exception ex) {
						throw ex;
					}
				} else {
					Log.Debug("Bad packet received.");
					Log.All("Data received: " + ((data == null) ? "" : string.Join(", ", data.Select(x => x.ToString("X2")))));
					//Console.Out.WriteLine("Bad packet received.");
				}
			} catch (Exception) {
				Log.Fatal("Error when attempting to receive data.");
				Disconnect();
			}
		}

		public override long? Ping(int timeoutMs = 3000) {
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
