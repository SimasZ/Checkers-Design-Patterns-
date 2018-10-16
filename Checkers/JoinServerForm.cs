using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkers {
	public partial class JoinServerForm : Form {
		public JoinServerForm() {
			InitializeComponent();
		}

		/*private bool checkIP(string ip) {
			IPAddress address;
			if (IPAddress.TryParse(ip, out address)) {
				return true;
			}
			label2.Text = "Wrong ip address!";
			return false;
		}*/

		private void button1_Click(object sender, EventArgs e) {
			string ip = "";
			if (NetConnection.GetIP(ref ip)) {
				IPAddress.TryParse(ip, out Singleton.Instance.ipAdress);
				label1.Text = "Your ip: " + ip;

				//Server ser = new Server();
				Net.ConnectionBase b = new Net.ConnectionBase(Singleton.Instance.ipAdress, false);
			}
			/*if (checkIP(textBox1.Text)) {
				IPAddress.TryParse(ip, out Singleton.Instance.ipAdress);
				//Net.Client client = new Net.Client(textBox1.Text);
				Net.ConnectionBase b = new Net.ConnectionBase(Singleton.Instance.ipAdress, false);
			}*/
		}
	}
}
