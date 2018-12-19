using Battleships.states;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships {
	class ChatHandler : Handler
	{
		public override void HandleLocal(string command, List<string> args, string line) {
			switch (command) {
				case "say": {
					Program.connection.SendCommand(command + " " + Globals.localUser.GetName() + " " + line.Substring(command.Length + 1));
				}
				return;
			}
			base.HandleLocal(command, args, line);
		}

		public override void HandleOut(string command, List<string> args, string line) {
			switch (command) {
				case "say": {
					//string message = line.Substring(command.Length + 1);
					//Console.WriteLine("Opponent says: " + message);
				    foreach (User user in Globals.users)
				    {
				        if (args[0] == user.GetName())
				        {
				            user.SendMessage(line.Substring(command.Length + args[0].Length + 2));
				        }
                    }
				}
				return;
			}
			base.HandleOut(command, args, line);
		}
	}
}
