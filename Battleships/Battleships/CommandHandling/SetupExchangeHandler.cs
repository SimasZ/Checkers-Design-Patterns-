using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships {
	class SetupExchangeHandler : Handler{
		BoardSetup setup;
		BoardSetup opponentSetup;

		public SetupExchangeHandler(BoardSetup _setup, BoardSetup _opponentSetup) {
			setup = _setup;
			opponentSetup = _opponentSetup;
		}

		public override void HandleOut(string command, List<string> args, string line) {
			switch (command) {
				case "opponentIsReady": {
					Console.WriteLine("Opponent is ready!");
					Program.connection.SendCommand(setup.ToCommand());
				}
				return;
				case "opponentLayout": {
					int cnt;
					Int32.TryParse(args[0], out cnt);
					string name;
					int x, y, rotated;
					int argOffset = 1;
					for (int i = 0;i < cnt;i++) {
						name = args[argOffset];
						Int32.TryParse(args[argOffset + 1], out x);
						Int32.TryParse(args[argOffset + 2], out y);
						Int32.TryParse(args[argOffset + 3], out rotated);
						opponentSetup.TryPlace(name, x, y, rotated == 1 ? true : false);
						argOffset += 4;
					}
				}
				return;
			}
			base.HandleOut(command, args, line);
		}
	}
}
