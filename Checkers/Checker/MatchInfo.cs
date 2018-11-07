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
