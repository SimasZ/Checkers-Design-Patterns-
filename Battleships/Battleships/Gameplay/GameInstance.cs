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
    }
}
