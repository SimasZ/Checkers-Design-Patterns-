using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships {
	abstract class Handler {
		private Handler sucessor;

		public virtual void HandleLocal(string command, List<string> args, string line) {
			if (sucessor != null) {
				sucessor.HandleLocal(command, args, line);
			} else {
				Console.WriteLine("No such command or this command is not allowed");
			}
		}

		public virtual void HandleOut(string command, List<string> args, string line) {
			if (sucessor != null) {
				sucessor.HandleOut(command, args, line);
			}
		}

		public Handler setSucessor(Handler _sucessor) {
			sucessor = _sucessor;
			return sucessor;
		}
	}
}
