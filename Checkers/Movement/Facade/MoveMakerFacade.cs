using System;

namespace Checkers.Movement.Facade
{
    public class MoveMakerFacade
    {
        private readonly MoveMaker _moveMaker;
        public MoveMakerFacade(MoveMaker moveMaker)
        {
            _moveMaker = moveMaker;
        }

        public void MakeMove(int x, int y)
        {
            Console.WriteLine("MoveMakerFacade.MakeMove is called");
            _moveMaker.MakeMove(x, y);
            _moveMaker.Notify();
        }
    }
}
