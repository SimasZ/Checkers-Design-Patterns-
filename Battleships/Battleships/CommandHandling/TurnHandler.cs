using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships.CommandHandling {
	class TurnHandler : Handler{
		public GameInstance instance;

		public override void HandleLocal(string command, List<string> args, string line) {
			switch (command) {
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
