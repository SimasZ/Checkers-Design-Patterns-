using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    class Board
    {
        private Tile[,] tileMap;

        private List<Unit> unitsList;
        private List<Ship> shipsList;

        public Board(BoardSetup setup)
        {
            tileMap = new Tile[Globals.boardSize, Globals.boardSize];
            for (int i = 0; i < Globals.boardSize; i++)
            {
                for (int j = 0; j < Globals.boardSize; j++)
                {
                    tileMap[i, j] = new Tile(i, j);
                }
            }

            unitsList = new List<Unit>();
            shipsList = new List<Ship>();

            var unitDataIterator = new UnitDataContainer(setup.placedEntities).GetIterator();

            while (unitDataIterator.HasNext())
            {
                UnitData unitData = (UnitData)unitDataIterator.Next();
                List<Tile> unitTiles = new List<Tile>();
                for (int j = 0; j < unitData.positions.Count; j += 2)
                {
                    unitTiles.Add(tileMap[unitData.positions[j], unitData.positions[j + 1]]);
                }
                if (unitData.layout.type == UnitLayout.Type.Ship)
                {
                    Ship ship = new Ship(unitTiles);
                    shipsList.Add(ship);
                    unitsList.Add(ship);
                }
            }
        }

        /*private void PlaceEntity(int x, int y)
        {
            tileMap[x, y].Use();
        }

        public void AddUnit(Unit unit)
        {
            unitList.Add(unit);
        }*/
    }
}
