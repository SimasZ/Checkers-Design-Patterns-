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

		private void CreateServer_Shown(Object sender, EventArgs e) {
			string ip = "";
			if (NetConnection.GetIP(ref ip)) {
				IPAddress.TryParse(ip, out Singleton.Instance.ipAdress);
				label1.Text = "Your ip: " + ip;

				Net.ConnectionBase b = new Net.ConnectionBase(Singleton.Instance.ipAdress, true, OpenGameForm);
			}

		}

		public void OpenGameForm() {
			Console.WriteLine("sdffhfsdh");

			GameForm form2 = new GameForm();
			form2.Closed += (s, args) => this.Close();
			form2.Show();
		}

		private void label1_Click(object sender, EventArgs e) {

		}
	}
}
