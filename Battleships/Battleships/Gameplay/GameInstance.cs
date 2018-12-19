using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    class GameInstance
    {
		public Board yourBoard { get; private set; }
		public Board opponentBoard { get; private set; }

		public bool yourTurn;

        public GameInstance(BoardSetup yourBoardSetup, BoardSetup opponentBoardSetup, bool _yourTurn)
        {
			yourBoard = new Board(yourBoardSetup);
			opponentBoard = new Board(opponentBoardSetup);
			yourTurn = _yourTurn;
		}

        public bool OpponentTileIsHit(int x, int y)
        {
            return opponentBoard.TileIsHit(x, y);
        }

        public bool HitOpponentBoard(int x, int y, out bool unitDestroyed)
        {
            return opponentBoard.HitTile(x, y, out unitDestroyed);
        }

        public bool HitYourBoard(int x, int y, out bool unitDestroyed)
        {
            return yourBoard.HitTile(x, y, out unitDestroyed);
        }

    }
}
