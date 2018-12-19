using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships {
	class Memento {
		public List<UnitLayout> unplacedUnits { get; private set; }
		public List<UnitData> placedUnits { get; private set; }

		public Memento(BoardSetup setup) {
			unplacedUnits = setup.unplacedEntities.ToList();
			placedUnits = setup.placedEntities.ToList();
		}
	}
}
