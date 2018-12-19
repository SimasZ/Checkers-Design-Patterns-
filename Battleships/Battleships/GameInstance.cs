using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    class GameInstance
    {
        private Board yourBoard { get; set; }
        private Board opponentBoard { get; set; }

        public GameInstance(BoardSetup yourBoardSetup)
        {
			yourBoard = new Board(yourBoardSetup);
		}
    }
}
