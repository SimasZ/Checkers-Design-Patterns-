namespace Checkers.Checker.Prototype
{
    public interface IPrototype<out T>
    {
        T Clone();
    }
}
