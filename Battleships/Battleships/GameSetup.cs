using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships {
	class GameSetup {
		public class PlacedEntity{
			public string name;
			public int x, y;
			public bool rotated;
		}

		public class UnplacedEntity {
			public string name;
			public string layout;

			public UnplacedEntity(string _name, string _layout) {
				name = _name;
				layout = _layout;
			}
		}

		public List<UnplacedEntity> unplacedEntities;
		public List<PlacedEntity> placedEntities;

		public GameSetup() {
			unplacedEntities = new List<UnplacedEntity>();
			unplacedEntities.Add(new UnplacedEntity("xlship", "++++"));
			unplacedEntities.Add(new UnplacedEntity("lship", "+++"));
			unplacedEntities.Add(new UnplacedEntity("lship", "+++"));
			unplacedEntities.Add(new UnplacedEntity("mship", "++"));
			unplacedEntities.Add(new UnplacedEntity("mship", "++"));
			unplacedEntities.Add(new UnplacedEntity("mship", "+"));

			placedEntities = new List<PlacedEntity>();
		}
	}
}
