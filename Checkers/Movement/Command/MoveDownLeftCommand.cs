﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checkers.Checker;


namespace Checkers.Movement.Command
{
    class MoveDownLeftCommand : Command
    {
        private Checker.Checker state;

        public MoveDownLeftCommand(Checker.Checker state)
        {
            this.state = state;
        }

        public override void Execute()
        {
            Console.WriteLine("MoveDownLeftCommand move from " + state.x + " " + state.y + " to " + (state.x - 1) + " " + (state.y - 1));
            state.ChangePosition(state.x - 1, state.y - 1);
        }
    }
}
