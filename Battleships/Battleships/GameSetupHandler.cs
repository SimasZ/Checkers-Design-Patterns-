using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships {
	class GameSetupHandler : Handler{
		private GameSetup setup;

		public GameSetupHandler(GameSetup _setup) {
			setup = _setup;
		}

		public override void HandleLocal(string command, List<string> args, string line) {
			switch (command) {
				case "print": {
					if (args.Count == 0) {
						break;
					}

					if (args.Count == 1) {
						break;
					}

					if (args[0] == "unplaced" && args[1] == "units") {
						for (int i = 0;i < setup.unplacedEntities.Count;i++) {
							Console.WriteLine(setup.unplacedEntities[i].name + " " + setup.unplacedEntities[i].layout);
						}
					}
					if (args[0] == "placed" && args[1] == "units") {
						for (int i = 0; i < setup.placedEntities.Count; i++) {
							Console.WriteLine(setup.placedEntities[i].name + " " + setup.placedEntities[i].x + " " + setup.placedEntities[i].y);
						}
					}
				}
				return;
			}
			base.HandleLocal(command, args, line);
		}

		public override void HandleOut(string command, List<string> args, string line) {
			switch (command) {

			}
			base.HandleOut(command, args, line);
		}
	}
}
