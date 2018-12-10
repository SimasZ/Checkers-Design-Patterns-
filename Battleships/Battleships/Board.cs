using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    class Board
    {
        private const int BOARDSIZE = 10;

        private Tile[,] tileMap;

        public Board()
        {
            tileMap = new Tile[BOARDSIZE, BOARDSIZE];
        }
        

    }
}
