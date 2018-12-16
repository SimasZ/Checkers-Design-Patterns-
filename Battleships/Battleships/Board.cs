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

        private List<Ship> ships;

        public Board()
        {
            tileMap = new Tile[BOARDSIZE, BOARDSIZE];
            ships = new List<Ship>();
            for (int i = 0; i < BOARDSIZE; i++)
            {
                for (int j = 0; j < BOARDSIZE; j++)
                {
                    tileMap[i, j] = new Tile(i,j);
                }
            }
        }
        
        private void PlaceEntity(int x, int y)
        {
            tileMap[x, y].Use();
        }

        public void AddShip(Ship ship)
        {
            ships.Add(ship);
        }
    }
}
