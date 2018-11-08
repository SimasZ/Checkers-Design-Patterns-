using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Checkers.Checker;
using Checkers.Checker.Factory;
using Checkers.Checker.Builder;
using Checkers.Checker.Singleton;
using Checkers.Movement.Command;

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

			/*Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new InitialForm());*/

			//singleton
			GameController.Instance.netListener = new Net.NetListener();
			
			//factory
			Checker.Checker c1 = CheckerFactory.CreateChecker("Pawn", Color.Green, 0, 0);

			//prototype (deep clone)
			Checker.Checker c2 = (Checker.Checker)c1.Clone();
			Console.WriteLine(c1.color == c2.color);

			//prototype (shallow clone)
			ClassicBoard classicBoard1 = new ClassicBoard(Color.DarkRed, Color.WhiteSmoke, 10);
			
			ClassicBoard classicBoard2 = (ClassicBoard)classicBoard1.Clone();
			Console.WriteLine(classicBoard1.subject == classicBoard2.subject);

			//builder
			BoardBuilder builder = new BoardBuilder();
			builder.addFirstColor(Color.Red);
			builder.addSecondColor(Color.White);
			GameBoard board = builder.getBoard(10, 10);


            // command
            Checker.Checker ch = new Checker.Checker(Color.Black, 2, 2, CheckerType.Pawn);
            Command command = new MoveDownLeftCommand(ch);
            command.Execute();
            command = new MoveDownRightCommand(ch);
            command.Execute();


            Console.ReadLine();
        }
	}
}
