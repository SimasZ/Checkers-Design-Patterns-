using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    public abstract class Weapon
    {
        private string hitPlaceHolder = "#";

        private string missPlaceHolder = "*";

        protected abstract void Fire();
    }
}
