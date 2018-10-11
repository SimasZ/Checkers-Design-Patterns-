using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkers {
	public partial class CreateServerForm : Form {
		public CreateServerForm() {
			InitializeComponent();
			Shown += CreateServer_Shown;
		}

		private string getIP() {
			var host = Dns.GetHostEntry(Dns.GetHostName());
			foreach (var ip in host.AddressList) {
				if (ip.AddressFamily == AddressFamily.InterNetwork) {
					return ip.ToString();
				}
			}
			return "";
		}

		private void CreateServer_Shown(Object sender, EventArgs e) {
			label1.Text = "Your ip: " + getIP().ToString();
		}

		private void label1_Click(object sender, EventArgs e) {

		}
	}
}
