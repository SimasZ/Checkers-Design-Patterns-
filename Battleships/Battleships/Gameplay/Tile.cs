using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    public class Tile
    {
        public bool isUsed { get; private set; }
        public bool isHit { get; private set; }
        public int x { get; private set; }
        public int y { get; private set; }


        public Tile(int _x, int _y)
        {
			isUsed = false;
			isHit = false;
			x = _x;
			y = _y;
        }

        public void Use()
        {
            this.isUsed = true;
        }

        public void Hit()
        {
            this.isHit = true;
        }
    }
}
