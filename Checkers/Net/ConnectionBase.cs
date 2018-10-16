using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Checkers.Net {
	class ConnectionBase {
		IPAddress ip;
		ASCIIEncoding asen;

		public ConnectionBase(IPAddress _ip, bool isServer) {
			ip = _ip;
			Thread t;
			if (isServer) {
				//t = new Thread(startServer);
				startServer();
			} else {
				//t = new Thread(startClient);
				startClient();
			}

			//t.Start();
		}

		public void startServer() {
			// use local m/c IP address, and 
			// use the same in the client

			/* Initializes the Listener */
			TcpListener myList = new TcpListener(ip, 8001);

			/* Start Listeneting at the specified port */
			myList.Start();

			Socket s = myList.AcceptSocket();

			while (true) {
				byte[] b = new byte[100];
				int k = s.Receive(b);
				Console.WriteLine("Recieved...");
				for (int i = 0; i < k; i++)
					Console.Write(Convert.ToChar(b[i]));

				asen = new ASCIIEncoding();
				s.Send(asen.GetBytes("The string was recieved by the server."));
				Console.WriteLine("\nSent Acknowledgement");
				/* clean up */
				s.Close();
				myList.Stop();
			}
		}

		public void startClient() {
			TcpClient tcpclnt = new TcpClient();
			Console.WriteLine("Connecting.....");

			tcpclnt.Connect(ip, 8001);

			while (true) {
				String str = Console.ReadLine();
				Stream stm = tcpclnt.GetStream();

				asen = new ASCIIEncoding();
				byte[] ba = asen.GetBytes(str);
				Console.WriteLine("Transmitting.....");

				stm.Write(ba, 0, ba.Length);

				byte[] bb = new byte[100];
				int k = stm.Read(bb, 0, 100);

				for (int i = 0; i < k; i++)
					Console.Write(Convert.ToChar(bb[i]));
			}
		}
	}
}
