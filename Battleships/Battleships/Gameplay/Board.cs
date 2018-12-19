using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Battleships.Gameplay;

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

                Ship ship = null;
                switch (unitData.layout.type)
                {
                    case UnitLayout.Type.SShip:
                        ship = new SShip(unitTiles);
                        break;
                    case UnitLayout.Type.MShip:
                        ship = new MShip(unitTiles);
                        break;
                    case UnitLayout.Type.LShip:
                        ship = new LShip(unitTiles);
                        break;
                    case UnitLayout.Type.XLShip:
                        ship = new XLShip(unitTiles);
                        break;
                }

                shipsList.Add(ship);
                unitsList.Add(ship);
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
