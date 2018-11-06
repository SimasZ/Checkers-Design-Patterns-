using System;
using System.Media;
using Checkers.Movement.Adapter;
using Checkers.Movement.Strategy;

namespace Checkers.Movement.Facade
{
    public class MoveMaker
    {
        private readonly ICheckerMovementStrategy _checkerMovementStrategy;
        private readonly INotify _notifier;

        public MoveMaker(ICheckerMovementStrategy checkerMovementStrategy, INotify notifier)
        {
            _checkerMovementStrategy = checkerMovementStrategy;
            _notifier = notifier;
        }

        public void MakeMove(int x, int y)
        {
            _checkerMovementStrategy.Move(x, y);
        }

        public void Notify()
        {
            _notifier.Notify();
        }
    }
}
