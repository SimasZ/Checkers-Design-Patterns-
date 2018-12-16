using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships {
	abstract class State {
		private static object lockObj = new object();

		protected Handler handler;

		public State() {
			PrintWelcomeMessage();
		}

		protected virtual void PrintWelcomeMessage() { }

		public void HandleCommand(bool io, string command, List<string> args, string line) {
			lock (lockObj) {
				if (io) {
					handler.HandleLocal(command, args, line);
				} else {
					handler.HandleOut(command, args, line);
				}
			}
		}
	}
}
