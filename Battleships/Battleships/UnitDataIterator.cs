using System.Collections.Generic;

namespace Battleships
{
    public class UnitDataIterator : IIterator
    {
        private readonly List<UnitData> _unitDataCollection;
        private int _index = 0;

        public UnitDataIterator(List<UnitData> unitDataCollection)
        {
            _unitDataCollection = unitDataCollection;
        }

        public bool HasNext()
        {
            return _index < _unitDataCollection.Count && _unitDataCollection[_index] != null;
        }

        public object Next()
        {
            UnitData notification = _unitDataCollection[_index];
            _index += 1;
            return notification;
        }
      
    }
}
