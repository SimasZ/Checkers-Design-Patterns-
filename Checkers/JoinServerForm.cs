﻿using System;
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
				IPAddress.TryParse(textBox1.Text, out Singleton.Instance.ipAdress);

				//Server ser = new Server();
				Net.ConnectionBase b = new Net.ConnectionBase(Singleton.Instance.ipAdress, false, OpenGameForm);
				//Net.Client client = new Net.Client(textBox1.Text);
			}
		}

		public void OpenGameForm() {
			Console.WriteLine("sdffhfsdh");

			this.Hide();
			GameForm form2 = new GameForm();
			form2.Closed += (s, args) => this.Close();
			form2.Show();
		}
	}
}
