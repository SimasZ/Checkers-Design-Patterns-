using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checkers.Net;

namespace Checkers.Checker
{
    class MatchInfo : Observer.Observer
    {
        private PlayerScore yourScore;
        private PlayerScore opponentScore;

        public MatchInfo(NetListener subject)
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
