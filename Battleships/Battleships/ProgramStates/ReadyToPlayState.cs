using Battleships.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Battleships.CommandHandling;

namespace Battleships {
	class ReadyToPlayState : State{
		BoardSetup setup;
		BoardSetup opponentSetup;
		SetupExchangeHandler setupExchangeHandler;

		public ReadyToPlayState(BoardSetup _setup) {
			setup = _setup;
			opponentSetup = new BoardSetup();

			handler = new ChatHandler();
			setupExchangeHandler = new SetupExchangeHandler(_setup, opponentSetup);
			handler.SetSuccessor(setupExchangeHandler).SetSuccessor(new UserHandler()).SetSuccessor(new HelpHandler());
		}

		public void Init(bool _opponentIsReady) {
			setupExchangeHandler.yourTurn = _opponentIsReady;
			if (_opponentIsReady) {
				Program.connection.SendCommand(setup.ToCommand());
			} else {
				Console.WriteLine("Waiting for other player...");
			}
		}
	}
}
