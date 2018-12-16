using Battleships.states;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Battleships {
	class Server : NetConnection{
		TcpListener tcp;
		Socket socket;

		public Server() {
			string ipStr = null;
			if (!GetIP(ref ipStr)) {
				return;
			}
			IPAddress adress;
			if (!IPAddress.TryParse(ipStr, out adress)) {
				return;
			}
			Console.WriteLine("hosting on ip: " + ipStr);

			tcp = new TcpListener(adress, port);
			tcp.Start();

			initialized = true;
			Thread thread = new Thread(waitForConnection);
			thread.Start();
		}

		public override void SendCommand(string message) {
			socket.Send(asen.GetBytes(message));
		}

		private void waitForConnection() {
			Console.WriteLine("Waiting for other player...");
			socket = tcp.AcceptSocket();
			connected = running = true;
			Console.WriteLine("Opponent has joined the game");
			Program.SwitchState(new GameSetupState());
			Thread thread = new Thread(connectionListener);
			thread.Start();
		}

		private void connectionListener() {
			byte[] b = new byte[1000];
			while (running) {
				int k = 0;
				try {
					k = socket.Receive(b);
				} catch (SocketException except) {
					Console.WriteLine("sfdh");
				}

				string message = "";
				for (int i = 0; i < k; i++)
					message += Convert.ToChar(b[i]);

				List<string> args = message.Split().ToList();
				if (args.Count <= 0) {
					continue;
				}
				string command = args[0];
				args.RemoveAt(0);
				Program.state.HandleCommand(false, command, args, message);
			}
			socket.Close();
			tcp.Stop();
		}
	}
}
