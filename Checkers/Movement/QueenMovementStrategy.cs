using System;

namespace Checkers.Movement
{
    public class QueenMovementStrategy : ICheckerMovementStrategy
    {
        public void Move(int x, int y)
        {
            Console.WriteLine($"Queen moves to X = {x}, Y = {y}");
        }
    }
}
