using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships {
	class UserHandler : Handler {
		public override void HandleLocal(string command, List<string> args, string line) {
			switch (command) {
				case "name":
					Globals.localUser.SetName(args[0]);
					if (!Program.connection.isNull()) {
						Program.connection.SendCommand("opponent_name " + args[0]);
					}
					return;
				case "opponent_name":
					Program.connection.SendCommand("opponent_name " + args[0]);
					return;
			}
			base.HandleLocal(command, args, line);
		}

		public override void HandleOut(string command, List<string> args, string line) {
			switch (command) {
				case "opponent_name":
					Globals.users.Add(new User(args[0]));
					return;
			}
			base.HandleOut(command, args, line);
		}
	}
}
