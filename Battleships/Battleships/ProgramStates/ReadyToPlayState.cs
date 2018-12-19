using Battleships.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships {
	class ReadyToPlayState : State{
		BoardSetup setup;
		BoardSetup opponentSetup;

		public ReadyToPlayState(BoardSetup _setup) {
			setup = _setup;
			opponentSetup = new BoardSetup();

			handler = new ChatHandler();
			handler.SetSucessor(new SetupExchangeHandler(_setup, opponentSetup));
		}

		public void Init(bool _opponentIsReady) {
			if (_opponentIsReady) {
				Program.connection.SendCommand(setup.ToCommand());
			} else {
				Console.WriteLine("Waiting for other player...");
			}
		}

		public override void HandleCommand(bool io, string command, List<string> args, string line) {
			base.HandleCommand(io, command, args, line);
			if (setup.UnitsArePlaced() && opponentSetup.UnitsArePlaced()) {
				Program.SwitchState(new GameplayState());
			}
		}
	}
}
