using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships {
	class InitialState : State{
		public InitialState() {
			handler = new ConnectionHandler();
		}

		protected override void PrintWelcomeMessage() {
			Console.WriteLine("Welcome to Balleships!");
			Console.WriteLine("Write: host - to create server;");
			Console.WriteLine("Write: join -ip - to join server.");
		}
	}
}
