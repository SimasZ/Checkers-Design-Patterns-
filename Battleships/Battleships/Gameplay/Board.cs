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
        
        public bool TileIsHit(int x, int y)
        {
            return tileMap[x, y].isHit;
        }


        public bool TileIsUsed(int x, int y)
        {
            return tileMap[x, y].isUsed;
        }

        private Ship GetTileShip(Tile tile)
        {
            foreach (Ship ship in shipsList)
            {
                if (ship.IsOnTile(tile))
                {
                    return ship;
                }
            }
            return null;
        }

        /// <returns> tile is used ? (true) : (false) </returns>
        public bool HitTile(int x, int y, out bool unitDestroyed)
        {
            tileMap[x, y].Hit();
            bool used = tileMap[x, y].isUsed;

            if (used)
            {
                Ship ship = GetTileShip(tileMap[x, y]);
                unitDestroyed = ship.IsSunken();
            }
            else
            {
                unitDestroyed = false;
                return false;
            }
            return used;
        }

        public void PrintMap(bool isOpponentMap)
        {
            for (int i = 0; i < Globals.boardSize; i++)
            {
                for (int j = 0; j < Globals.boardSize; j++)
                {
                    if (tileMap[i, j].isUsed)
                    {
                        if (tileMap[i, j].isHit)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("# ");
                            Console.ResetColor();
                        }
                        else if(!isOpponentMap)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("+ ");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("~ ");
                            Console.ResetColor();
                        }
                    }
                    else
                    {
                        if (tileMap[i, j].isHit)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("* ");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("~ ");
                            Console.ResetColor();
                        }
                    }
                }
                Console.WriteLine();
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
