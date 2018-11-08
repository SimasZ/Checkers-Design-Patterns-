using System.Drawing;

namespace Checkers.Checker.Factory
{
    public class CheckerFactory
    {
        public static Checker CreateChecker(string type, Color color, int x, int y)
        {
            if (type == "Pawn")
            {
                return new Checker(color, x, y, CheckerType.Pawn);
            }
            if (type == "Queen")
            {
                return new Checker(color, x, y, CheckerType.Queen);
            }
            return null;
        }
    }
}
