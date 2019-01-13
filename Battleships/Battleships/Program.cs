using Battleships.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships {
	class Program
	{
		private static object lockObj = new object();

		public static NetConnection connection;
		public static State state { get; private set; }

		static void Main(string[] args) {
			Program program = new Program();
			program.start();
		}

		public Program() {
			connection = new NullConnection();
			state = new InitialState();
            Globals.localUser = new User();
            Globals.users.Add(Globals.localUser);
		}

		public void start() {
			while (true) {
				string line = Console.ReadLine();
				List<string> args = line.Split().ToList();
				if (args.Count <= 0) {
					continue;
				}
				string command = args[0];
				args.RemoveAt(0);

				lock (lockObj) {
					state.HandleCommand(true, command, args, line);
				}
			}
		}

		public static void SwitchState(State newState) {
			lock (lockObj) {
				state = newState;
			}
		}
	}
}
