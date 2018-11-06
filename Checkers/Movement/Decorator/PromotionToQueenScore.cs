namespace Checkers.Movement.Decorator
{
    public class PromotionToQueenScore : Decorator
    {
        public override int GetScore()
        {
            return base.GetScore() + 2;
        }
    }
}
