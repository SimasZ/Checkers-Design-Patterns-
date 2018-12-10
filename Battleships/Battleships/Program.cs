using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships {
	class Program {
		public static NetConnection connection;
		private static Handler handler;
		private static object lockObj;

		static void Main(string[] args) {
			Program program = new Program();
			program.start();
		}

		public Program() {
			handler = new ConnectionHandler();
			handler.setSucessor(new ChatHandler());
			lockObj = new object();
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
				handleCommand(true, command, args, line);
			}
		}

		public static void handleCommand(bool io, string command, List<string> args, string line) {
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
