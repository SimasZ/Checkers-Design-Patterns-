using System.Collections.Generic;

namespace Battleships.Gameplay
{
    public class SShip : Ship
    {
        public SShip(List<Tile> tiles) : base(tiles)
        {
        }

        public override bool IsMovable()
        {
            return false;
        }

        public override bool IsRotatable()
        {
            return false;
        }
    }
}
