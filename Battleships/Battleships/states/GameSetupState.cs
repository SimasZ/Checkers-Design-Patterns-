using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships.states {
	class GameSetupState : State{
		private GameSetup setup;

		public GameSetupState() {
			setup = new GameSetup();

			handler = new ChatHandler();
			handler.setSucessor(new GameSetupHandler(setup));
			PrintWelcomeMessage2();
		}

		protected override void PrintWelcomeMessage() {
			Console.WriteLine("Please setup your ships");
			Console.WriteLine("Board size is " + Globals.boardSize + "x" + Globals.boardSize);
		}

		protected void PrintWelcomeMessage2() {
			Console.WriteLine("Ships list");
			handler.HandleLocal("print", new List<string>() { "unplaced", "units" }, "");
		}
	}
}
