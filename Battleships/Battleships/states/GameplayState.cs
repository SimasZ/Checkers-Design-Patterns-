using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships.States {
	class GameplayState : State{

		protected override void PrintWelcomeMessage() {
			Console.WriteLine("Ready to play");
		}
	}
}
