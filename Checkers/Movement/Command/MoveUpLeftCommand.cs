using System;
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

            Console.WriteLine("MoveUpLeftCommand move from " + state.x + " " + state.y + " to " + (state.x - 1) + " " + (state.y + 1));
            state.ChangePosition(state.x - 1, state.y + 1);
        }
    }
}
