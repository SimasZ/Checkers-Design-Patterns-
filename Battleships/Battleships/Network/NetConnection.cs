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
	class NetConnection {
		public static int port = 8001;

		IPAddress ip;
		protected ASCIIEncoding asen = new ASCIIEncoding();

		public bool initialized { get; protected set; }
		public bool connected { get; protected set; }
		public bool running { get; protected set; }

		public NetConnection() {

		}

		public virtual void SendCommand(string message) { }

		public bool GetIP(ref string ipStr) {
			var host = Dns.GetHostEntry(Dns.GetHostName());
			foreach (var ip in host.AddressList) {
				if (ip.AddressFamily == AddressFamily.InterNetwork) {
					ipStr = ip.ToString();
					return true;
				}
			}
			return false;
		}
	}
}
