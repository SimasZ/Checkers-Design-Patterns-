using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships {
	class GameSetupHandler : Handler{
		private BoardSetup setup;
		private Memento memento;
		private bool opponentIsReady;

		public GameSetupHandler(BoardSetup _setup) {
			setup = _setup;
		}

		public override void HandleLocal(string command, List<string> args, string line) {
			switch (command) {
				case "print": {
					if (args.Count == 0) {
						break;
					}

					if (args[0] == "map") {
						setup.PrintMap();
						return;
					}

					if (args.Count == 1) {
						break;
					}

					if (args[0] == "unplaced" && args[1] == "units") {
						for (int i = 0;i < setup.unplacedEntities.Count;i++) {
							Console.WriteLine(setup.unplacedEntities[i].name + " of size " + setup.unplacedEntities[i].layoutStr);
						}
					}
					if (args[0] == "placed" && args[1] == "units") {
						for (int i = 0; i < setup.placedEntities.Count; i++) {
							Console.WriteLine(setup.placedEntities[i].layout.name + " " + setup.placedEntities[i].x + " " + setup.placedEntities[i].y);
						}
					}
				}
				return;
				case "place": {
					if (args.Count != 4) {
						break;
					}
					string unitName = args[0];
					int x, y, rotationInt;
					bool rotated;

					Int32.TryParse(args[1], out x);
					Int32.TryParse(args[2], out y);
					Int32.TryParse(args[3], out rotationInt);
					rotated = rotationInt == 0 ? false : true;

					Memento nMemento = setup.CreateMemento();
					if (setup.TryPlace(unitName, x, y, rotated)) {
						if (setup.UnitsArePlaced()) {
							Console.WriteLine("All units are placed!");
							Program.connection.SendCommand("opponentIsReady");
							ReadyToPlayState state = new ReadyToPlayState(setup);
							Program.SwitchState(state);
							state.Init(opponentIsReady);
						} else {
							memento = nMemento;
							Console.WriteLine("Unit placed!");
						}
					}
				}
				return;
				case "undo": {
					if (memento != null) {
						setup.Restore(memento);
						memento = null;
						Console.WriteLine("Unit restored");
					} else {
						Console.WriteLine("Cant undo");
					}
				}
				return;
			}
			base.HandleLocal(command, args, line);
		}

		public override void HandleOut(string command, List<string> args, string line) {
			switch (command) {
				case "opponentIsReady": {
					Console.WriteLine("Opponent is ready!");
					opponentIsReady = true;
				}
				return;
			}
			base.HandleOut(command, args, line);
		}
	}
}
