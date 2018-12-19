using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships.states {
	class GameSetupState : State{
		private BoardSetup setup;

		public GameSetupState() {
			UnitLayoutFactory factory = new UnitLayoutFactory();
			factory.GetLayout("s_ship").Setup(UnitLayout.Type.Ship, "+");
			factory.GetLayout("m_ship").Setup(UnitLayout.Type.Ship, "++");
			factory.GetLayout("l_ship").Setup(UnitLayout.Type.Ship, "+++");
			factory.GetLayout("xl_ship").Setup(UnitLayout.Type.Ship, "++++");
			BoardSetup.factory = factory;

			setup = new BoardSetup();

			handler = new ChatHandler();
			handler.SetSucessor(new GameSetupHandler(setup));
			PrintWelcomeMessage2();
            handler.HandleLocal("opponent_name", new List<string>(){Globals.localUser.GetName()}, "");
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
