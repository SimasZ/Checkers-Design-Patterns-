namespace Checkers.Movement
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
            _moveMaker.MakeMove(x, y);
            _moveMaker.PlaySound();
        }
    }
}
