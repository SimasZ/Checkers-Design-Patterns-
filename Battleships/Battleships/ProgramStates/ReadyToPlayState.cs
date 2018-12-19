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
		SetupExchangeHandler setupExchangeHander;

		public ReadyToPlayState(BoardSetup _setup) {
			setup = _setup;
			opponentSetup = new BoardSetup();

			handler = new ChatHandler();
			setupExchangeHander = new SetupExchangeHandler(_setup, opponentSetup);
			handler.SetSuccessor(setupExchangeHander).SetSuccessor(new UserHandler());
		}

		public void Init(bool _opponentIsReady) {
			setupExchangeHander.yourTurn = _opponentIsReady;
			if (_opponentIsReady) {
				Program.connection.SendCommand(setup.ToCommand());
			} else {
				Console.WriteLine("Waiting for other player...");
			}
		}
	}
}
