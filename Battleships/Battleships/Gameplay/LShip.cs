using System;
using System.Collections.Generic;

namespace Battleships.Gameplay
{
    public class LShip : Ship
    {
        public LShip(List<Tile> tiles) : base(tiles)
        {
        }

        public override void Rotate()
        {
            Console.WriteLine("LShip is rotating");
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
