namespace Checkers.Movement.Decorator
{
    public class EliminatedQueenScore : Decorator
    {
        public override int GetScore()
        {
            return base.GetScore() + 4;
        }
    }
}
