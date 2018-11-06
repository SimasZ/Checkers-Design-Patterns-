using System;

namespace Checkers.Movement.Strategy
{
    public class PawnMovementStrategy : ICheckerMovementStrategy
    {
        public void Move(int x, int y)
        {
            Console.WriteLine($"Pawn moves to X = {x}, Y = {y}");
        }
    }
}
