namespace Checkers.Movement.Decorator
{
    public class DefaultMoveScore : IMoveScore
    {
        public int GetScore()
        {
            return 1;
        }
    }
}
