using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkers {
	class Program {
		[STAThread]
		static void Main(string[] args) {
			/*var host = Dns.GetHostEntry(Dns.GetHostName());
			foreach (var ip in host.AddressList) {
				if (ip.AddressFamily == AddressFamily.InterNetwork) {
					Console.WriteLine(ip.ToString());
				}
			}
			throw new Exception("No network adapters with an IPv4 address in the system!");*/

			/*ConnectionForm m = new ConnectionForm();
			m.Show();*/

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new InitialForm());
		}
	}
}
