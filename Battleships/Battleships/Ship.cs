using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    abstract class Ship : Unit
    {
        public string ShipName { get; private set; }
        public Weapon Weapon { get; private set; }

        public Ship(Tile[] tiles) : base(tiles)
        {

        }

        public bool IsSunken()
        {
            foreach (var tile in this.tiles)
            {
                if (!tile.IsHit) // All tiles have to be hit to consider ship sunken
                {
                    return false;
                }
            }
            return true;
        }

        private void SetTilesAsUsed()
        {
            foreach (var tile in tiles)
            {
                tile.Use();
            }
        }

        abstract public void Move();
        abstract public bool IsMovable();
        abstract public bool IsRotatable();
        abstract public void Rotate();


    }
}
