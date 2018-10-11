using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Checkers {
	class NetConnection {
		public static bool GetIP(ref string ipStr) {
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
