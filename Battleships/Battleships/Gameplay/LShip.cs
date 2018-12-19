using System.Collections.Generic;

namespace Battleships.Gameplay
{
    public class LShip : Ship
    {
        public LShip(List<Tile> tiles) : base(tiles)
        {
        }

        public override bool IsMovable()
        {
            return false;
        }

        public override bool IsRotatable()
        {
            return true;
        }
    }
}
