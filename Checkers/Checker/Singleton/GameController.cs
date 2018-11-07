using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checkers.Net;

namespace Checkers.Checker.Singleton {
	class GameController {
		private static readonly GameController INSTANCE = new GameController();

		public NetListener netListener;

		public static GameController Instance {
			get {
				return INSTANCE;
			}
		}
	}
}
