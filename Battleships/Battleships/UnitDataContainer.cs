using System.Collections.Generic;

namespace Battleships
{
    public class UnitDataContainer : IAggregate
    {
        private readonly List<UnitData> _unitDataContainer;

        public UnitDataContainer(List<UnitData> unitDataContainer)
        {
            _unitDataContainer = unitDataContainer;
        }

        public IIterator GetIterator()
        {
            return new UnitDataIterator(_unitDataContainer);
        }
    }
}
