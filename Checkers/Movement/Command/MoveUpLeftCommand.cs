﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checkers.Checker;

namespace Checkers.Movement.Command
{
    class MoveUpLeftCommand : Command
    {
        private Checker.Checker state;

        public MoveUpLeftCommand(Checker.Checker state)
        {
            this.state = state;
        }

        public override void Execute()
        {
            state.ChangePosition(state.X - 1, state.Y + 1);
        }
    }
}