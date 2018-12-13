using Battleships.states;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Battleships {
	class ConnectionHandler : Handler {
		public override void HandleLocal(string command, List<string> args, string line) {
			switch (command) {
				case "host": {
					NetConnection connection = new Server();
					if (!connection.initialized) {
						Console.WriteLine("Server could not be created");
						return;
					}
					Program.connection = connection;
				}
				return;
				case "join": {
					if (args.Count <= 0) {
						Console.WriteLine("Ip not set");
						return;
					}
					IPAddress ip;
					if (!IPAddress.TryParse(args[0], out ip)) {
						Console.WriteLine("Bad ip adress");
						return;
					}
					Console.WriteLine("Sucessfully joined server");
					Program.connection = new Client(ip);
					Program.SwitchState(new GameSetupState());
				}
				return;
			}
			base.HandleLocal(command, args, line);
		}
	}
}
