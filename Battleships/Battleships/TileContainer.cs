namespace Battleships
{
    public class TileContainer : IAggregate
    {
        private readonly Tile[] _tileCollection;

        public TileContainer(Tile[] tileContainer)
        {
            _tileCollection = tileContainer;
        }

        public IIterator GetIterator()
        {
            return new TileIterator(_tileCollection);
        }
    }
}
