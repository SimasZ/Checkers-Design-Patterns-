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

        private List<Unit> unitList;

        public Board()
        {
            tileMap = new Tile[BOARDSIZE, BOARDSIZE];
            unitList = new List<Unit>();
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

        public void AddUnit(Unit unit)
        {
            unitList.Add(unit);
        }
    }
}
