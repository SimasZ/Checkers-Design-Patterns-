using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checkers.Checker;


namespace Checkers.Movement.Command
{
    class MoveUpRightCommand : Command
    {
        private Checker.Checker state;

        public MoveUpRightCommand(Checker.Checker state)
        {
            this.state = state;
        }

        public override void Execute()
        {

            Console.WriteLine("MoveUpRightCommand move from " + state.x + " " + state.y + " to " + (state.x + 1) + " " + (state.y + 1));
            state.ChangePosition(state.x + 1, state.y + 1);
        }
    }
}
