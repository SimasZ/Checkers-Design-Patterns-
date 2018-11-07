using System;
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
            state.ChangePosition(state.X - 1, state.Y - 1);
        }
    }
}
