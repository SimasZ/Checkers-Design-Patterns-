using Battleships.CommandHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships.States {
	class GameplayState : State{

		public GameplayState(BoardSetup yourBoard, BoardSetup opponentBoard, bool _yourTurn) {
			TurnHandler turnHandler = new TurnHandler();
			turnHandler.SetSuccessor(new ChatHandler()).SetSuccessor(new UserHandler());

			turnHandler.instance = new GameInstance(yourBoard, opponentBoard, _yourTurn);

			handler = turnHandler;

			if (_yourTurn) {
				Console.WriteLine("Your turn");
			} else {
				Console.WriteLine("Its opponents turn");
			}
		}

		protected override void PrintWelcomeMessage() {
			Console.WriteLine("Ready to play");
		}
	}
}
