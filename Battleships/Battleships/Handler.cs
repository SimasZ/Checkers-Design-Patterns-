using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships {
	abstract class Handler {
		private Handler successor = null;

		public virtual void HandleLocal(string command, List<string> args, string line) {
			if (successor != null) {
				successor.HandleLocal(command, args, line);
			} else {
				Console.WriteLine("No such command or this command is not allowed");
			}
		}

		public virtual void HandleOut(string command, List<string> args, string line) {
			if (successor != null) {
				successor.HandleOut(command, args, line);
			}
		}

		public Handler setSucessor(Handler _successor) {
			successor = _successor;
			return successor;
		}
	}
}
