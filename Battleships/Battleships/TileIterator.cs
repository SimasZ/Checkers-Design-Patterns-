namespace Battleships
{
    public class TileIterator : IIterator
    {
        private readonly Tile[] _tileCollection;
        private int _index = 0;

        public TileIterator(Tile[] tileCollection)
        {
            _tileCollection = tileCollection;
        }

        public bool HasNext()
        {
            return _index < _tileCollection.Length && _tileCollection[_index] != null;
        }

        public object Next()
        {
            Tile notification = _tileCollection[_index];
            _index += 1;
            return notification;
        }
      
    }
}
