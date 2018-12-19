using System.Collections.Generic;

namespace Battleships.Gameplay
{
    public class XLShip : Ship
    {
        public XLShip(List<Tile> tiles) : base(tiles)
        {
        }

        public override bool IsMovable()
        {
            return true;
        }

        public override bool IsRotatable()
        {
            return false;
        }
    }
}
