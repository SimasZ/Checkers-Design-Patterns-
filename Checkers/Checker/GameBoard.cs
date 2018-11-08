using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checkers.Checker.Prototype;
using Checkers.Net;
using Checkers.Checker.Singleton;

namespace Checkers.Checker {
	abstract class GameBoard : Observer.Observer, IPrototype {
		public GameBoard(Color firstColor, Color secondColor)
        {
            this.subject = GameController.Instance.netListener;
            this.subject.RegisterObserver(this);
		}

        public override void Update()
        {
            //update something
        }

	    public abstract object Clone();
	}
}
