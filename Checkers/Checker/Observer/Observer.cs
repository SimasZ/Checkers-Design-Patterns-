using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checkers.Net;

namespace Checkers.Checker.Observer
{
    public abstract class Observer
    {
        internal NetListener subject;
        public abstract void Update();
    }
}
