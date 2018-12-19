using System.Collections.Generic;

namespace Battleships.Gameplay
{
    public class MShip : Ship
    {
        public MShip(List<Tile> tiles) : base(tiles)
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
