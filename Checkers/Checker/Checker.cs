using System.Drawing;
using Checkers.Checker.Prototype;

namespace Checkers.Checker
{
    public class Checker : IPrototype
    {
        public Color color { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public CheckerType type { get; set; }

        public Checker(Color _color, int _x, int _y, CheckerType _type)
        {
            color = _color;
            x = _x;
            y = _y;
            type = _type;
        }

        public void TurnToQueen()
        {
            type = CheckerType.Queen;
        }

        public void ChangePosition(int _x, int _y)
        {
            x = x;
            y = y;
        }

        public object Clone()
        {
            return (Checker) MemberwiseClone();
        }
    }
}
