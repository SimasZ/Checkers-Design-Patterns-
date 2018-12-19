using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    class Ship : Unit
    {
        public string shipName { get; private set; }
        public Weapon weapon { get; private set; }

        public Ship(List<Tile> tiles) : base(tiles)
        {

        }

        public bool IsSunken()
        {
            foreach (var tile in this.tiles)
            {
                if (!tile.isHit) // All tiles have to be hit to consider ship sunken
                {
                    return false;
                }
            }
            return true;
        }

		public void Move() { }
		public bool IsMovable() { return false; }
		public bool IsRotatable() { return false; }
		public void Rotate() { }
    }
}
