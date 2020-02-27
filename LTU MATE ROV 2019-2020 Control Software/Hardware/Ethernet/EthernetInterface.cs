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
	public class EthernetInterface : IEthernetLayer{

		public int DestinationPort { get; } = 6001;
		public int ReceivePort { get; } = 6002;
		public string TargetIp { get; set; } = "169.254.240.157"; //255.255.255.255

		public override bool IsSimulator => false;

		//private volatile bool connected = false;
		//public bool Connected { get => connected; private set => connected = value; }

		private UdpClient client;
		private Random random = new Random();

		//public delegate void NewPacketHandler(UdpPacket packet);
		//public event NewPacketHandler OnPacketReceived;

		public EthernetInterface() {

		}
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

		protected override bool TryConnect() {
			lock (this) {
				try {
					client = new UdpClient();
					client.Client.Bind(new IPEndPoint(IPAddress.Any, ReceivePort));
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
					//TODO exception thrown
				}
			}
		}

		protected override bool SendBytes(byte[] bytes) {
			try {
				client.Send(bytes, bytes.Length, TargetIp, DestinationPort);
				return true;
			} catch (Exception ex) {
				Console.Error.WriteLine("Error sending packet: {0}", ex.Message);
				Console.Error.WriteLine(ex.StackTrace);
				return false;
			}
		}

		private void OnDataReceived(IAsyncResult res) {
			try {
				byte[] data = null;
				lock (this) { //TODO only lock what is necessary. Don't lock the callback function
					IPEndPoint ip = new IPEndPoint(IPAddress.Any, ReceivePort);
					data = client.EndReceive(res, ref ip);
					client.BeginReceive(new AsyncCallback(OnDataReceived), null);
				}

				UdpPacket packet = UdpPacket.ParseData(data);
				if (packet != null) InvokePacketReceived(packet); //TODO don't catch exception for called function.
				else Console.Out.WriteLine("Bad packet received."); //TODO logger
			} catch (Exception e) {
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
