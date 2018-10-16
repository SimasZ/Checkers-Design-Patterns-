﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.Net {
	class Client{
		public Client(string serverIp) {
			TcpClient tcpclnt = new TcpClient();
			Console.WriteLine("Connecting.....");

			tcpclnt.Connect(serverIp, 8001);
			// use the ipaddress as in the server program

			Console.WriteLine("Connected");
			Console.Write("Enter the string to be transmitted : ");

			String str = Console.ReadLine();
			Stream stm = tcpclnt.GetStream();

			ASCIIEncoding asen = new ASCIIEncoding();
			byte[] ba = asen.GetBytes(str);
			Console.WriteLine("Transmitting.....");

			stm.Write(ba, 0, ba.Length);

			byte[] bb = new byte[100];
			int k = stm.Read(bb, 0, 100);

			for (int i = 0; i < k; i++)
				Console.Write(Convert.ToChar(bb[i]));

			tcpclnt.Close();
		}
	}


}