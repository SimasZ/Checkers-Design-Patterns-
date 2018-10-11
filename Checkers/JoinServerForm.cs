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

		private bool checkIP(string ip) {
			IPAddress address;
			if (IPAddress.TryParse(ip, out address)) {
				return true;
			}
			label2.Text = "Wrong ip address!";
			return false;
		}

		private void button1_Click(object sender, EventArgs e) {
			if (checkIP(textBox1.Text)) {

			}
		}
	}
}
