﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.Checker
{
    class PlayerScore
    {
        public int score;

        public void AddMoveScore(int score)
        {
            score += score;
        }
    }
}
