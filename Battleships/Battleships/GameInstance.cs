using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    class GameInstance
    {
        private Board YourBoard { get; set; }
        private Board OpponentBoard { get; set; }

        public GameInstance()
        {
            YourBoard = new Board();
            OpponentBoard = new Board();
        }
        



    }
}
