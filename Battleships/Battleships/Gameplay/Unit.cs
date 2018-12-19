using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    abstract class Unit
    {
        protected List<Tile> tiles;

        public Unit(List<Tile> tiles)
        {
            this.tiles = tiles;
			foreach (var tile in tiles) {
				tile.Use();
			}
		}

    }
}
