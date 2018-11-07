using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checkers.Net;

namespace Checkers.Checker {
	abstract class GameBoard : Observer.Observer {
		public GameBoard(Color firstColor, Color secondColor, NetListener subject)
        {
            this.subject = subject;
            this.subject.RegisterObserver(this);
		}

        public override void Update()
        {
            //update something
        }
    }
}
