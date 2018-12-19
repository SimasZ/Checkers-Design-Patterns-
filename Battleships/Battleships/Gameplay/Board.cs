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
			for (int i = 0; i < setup.placedEntities.Count; i++) {
				UnitData ent = setup.placedEntities[i];
				List<Tile> unitTiles = new List<Tile>();
				for (int j = 0; j < ent.positions.Count; j += 2) {
					unitTiles.Add(tileMap[ent.positions[j], ent.positions[j + 1]]);
				}
				if (ent.layout.type == UnitLayout.Type.Ship) {
					Ship ship = new Ship(unitTiles);
					shipsList.Add(ship);
					unitsList.Add(ship);
				}
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
