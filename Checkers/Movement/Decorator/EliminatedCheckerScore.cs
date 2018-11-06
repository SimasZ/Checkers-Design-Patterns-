namespace Checkers.Movement.Decorator
{
    public class EliminatedCheckerScore : Decorator
    {
        public override int GetScore()
        {
            return base.GetScore() + 3;
        }
    }
}
