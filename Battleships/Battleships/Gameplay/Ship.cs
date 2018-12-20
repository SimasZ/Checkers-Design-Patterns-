using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    public abstract class Ship : Unit
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

        public bool IsOnTile(Tile tile)
        {
            return tiles.Contains(tile);
        }
        public virtual void Move()
        {
            Console.WriteLine("Movable Ship is moving");
        }

        public abstract bool IsMovable();
        public abstract bool IsRotatable();

        public virtual void Rotate()
        {
            Console.WriteLine("Rotatable Ship is rotating");
        }

        public void Radio()
        {
            Console.WriteLine("Ship is radioing");
        }

        public void TemplateMethod()
        {
            Radio(); // default method
            if (IsRotatable())
            {
                Rotate(); // hook method
            }
            if (IsMovable())
            {
                Move(); // hook method
            }
        }
    }
}
