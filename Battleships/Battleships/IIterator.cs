namespace Battleships
{
    public interface IIterator
    {
        bool HasNext();
        object Next();
    }
}
