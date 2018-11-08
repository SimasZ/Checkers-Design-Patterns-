using System.Drawing;
using Checkers.Checker.Prototype;

namespace Checkers.Checker
{
    public class Checker : IPrototype
    {
        public Color Color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public CheckerType Type { get; set; }

        public Checker(Color color, int x, int y, CheckerType type)
        {
            Color = color;
            X = x;
            Y = y;
            Type = type;
        }

        public void TurnToQueen()
        {
            Type = CheckerType.Queen;
        }

        public void ChangePosition(int x, int y)
        {
            X = x;
            Y = y;
        }

        public object Clone()
        {
            return (Checker) MemberwiseClone();
        }
    }
}
