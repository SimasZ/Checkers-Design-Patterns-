﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    class Unit
    {
        protected Tile[] tiles;

        public Unit(Tile[] tiles)
        {
            this.tiles = tiles;
        }

    }
}
