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
			public string layout;

			public PlacedEntity(string _name, string layout, int _x, int _y, bool _rotated) {
				name = _name;
				x = _x;
				y = _y;
				rotated = _rotated;
			}
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

		public void TryPlace(string name, int x, int y, bool rotated) {
			bool shipFound = false;
			for (int i = 0;i < unplacedEntities.Count;i++) {
				if (unplacedEntities[i].name == name) {
					shipFound = true;
					if (CheckForClearance(unplacedEntities[i], x, y, rotated)) {
						placedEntities.Add(new PlacedEntity(unplacedEntities[i].name, unplacedEntities[i].layout, x, y, rotated));
						unplacedEntities.RemoveAt(i);
						if (unplacedEntities.Count == 0) {
							UnitsArePlaced();
						}
						return;
					}
				}
			}
			if (!shipFound) {
				Console.WriteLine("Unit with this name is not found.");
			}
		}

		public void UnitsArePlaced() {

		}

		public bool CheckForClearance(UnplacedEntity ent, int x, int y, bool rotated) {
			int subX = 0, subY = 0;
			char[] arr = ent.layout.ToCharArray();
			for (int i = 0;i < arr.Length; i++) {
				if (arr[i] == '+') {
					if (!CheckPos(x + subX, y + subY)) {
						Console.WriteLine("Cant place ship in this position");
						return false;
					}
					subX++;
				} else if (arr[i] == '\n') {
					subY++;
				}
			}
			return true;
		}

		public bool CheckPos(int x, int y) {
			if (x < 0 || y < 0) {
				return false;
			}
			if (x >= Globals.boardSize || y >= Globals.boardSize) {
				return false;
			}
			/*for (int ) {

			}*/
			return true;
		}
	}
}
