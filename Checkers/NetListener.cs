using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers {
	class NetListener {
		IConnection connection;

		public NetListener(int isServer) {
			connection = new Client();

		}

		
	}
}
