using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Battleships {
	class Client : NetConnection {
		TcpClient tcp;
		Stream stream;

		public Client(IPAddress _ip) {
			tcp = new TcpClient();
			tcp.Connect(_ip, port);
			stream = tcp.GetStream();

			initialized = connected = running = true;

			Thread t = new Thread(connectionListener);
			running = true;
			t.Start();
		}

		public override void SendCommand(string message) {
			byte[] ba = asen.GetBytes(message);
			stream.Write(ba, 0, ba.Length);
		}

		private void connectionListener() {
			byte[] b = new byte[1000];
			while (running) {
				int k = stream.Read(b, 0, 1000);

				string message = "";
				for (int i = 0; i < k; i++)
					//Console.Write(Convert.ToChar(b[i]));
					message += Convert.ToChar(b[i]);

				List<string> args = message.Split().ToList();
				if (args.Count <= 0) {
					continue;
				}
				string command = args[0];
				args.RemoveAt(0);
				Program.state.HandleCommand(false, command, args, message);
			}
		}

		public override bool isNull() {
			return false;
		}
	}
}
