using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    public class Tile
    {
        public bool IsUsed { get; private set; }
        public bool IsHit { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }


        public Tile()
        {
            IsUsed = false;
            IsHit = false;
        }

        public void Use()
        {
            this.IsUsed = true;
        }

        public void Hit()
        {
            this.IsHit = true;
        }
    }
}
