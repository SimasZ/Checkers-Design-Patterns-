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

			public PlacedEntity(string _name, string _layout, int _x, int _y, bool _rotated) {
				name = _name;
				x = _x;
				y = _y;
				layout = _layout;
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
			for (int i = 0;i < unplacedEntities.Count;i++) {
				if (unplacedEntities[i].name == name) {
					if (CheckForClearance(unplacedEntities[i], x, y, rotated)) {
						placedEntities.Add(new PlacedEntity(unplacedEntities[i].name, unplacedEntities[i].layout, x, y, rotated));
						unplacedEntities.RemoveAt(i);
						if (unplacedEntities.Count == 0) {
							UnitsArePlaced();
						}
					}
					return;
				}
			}
			Console.WriteLine("Unit with this name is not found.");
		}

		private void UnitsArePlaced() {

		}

		private bool CheckForClearance(UnplacedEntity ent, int x, int y, bool rotated) {
			int subX = 0, subY = 0;
			char[] arr = ent.layout.ToCharArray();
			if (rotated == false) {
				for (int i = 0; i < arr.Length; i++) {
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
			} else {
				for (int i = 0; i < arr.Length; i++) {
					if (arr[i] == '+') {
						if (!CheckPos(x + subX, y + subY)) {
							Console.WriteLine("Cant place ship in this position");
							return false;
						}
						subY++;
					} else if (arr[i] == '\n') {
						subX--;
					}
				}
			}
			
			return true;
		}

		public void PrintMap() {
			bool[,] map = new bool[Globals.boardSize, Globals.boardSize];
			int subX, subY, tempX, tempY;
			for (int i = 0; i < placedEntities.Count; i++) {
				tempX = placedEntities[i].x;
				tempY = placedEntities[i].y;
				subX = subY = 0;
				char[] arr = placedEntities[i].layout.ToCharArray();
				if (placedEntities[i].rotated == false) {
					for (int j = 0; j < arr.Length; j++) {
						if (arr[j] == '+') {
							map[tempX + subX, tempY + subY] = true;
							subX++;
						} else if (arr[i] == '\n') {
							subY++;
						}
					}
				} else {
					for (int j = 0; j < arr.Length; j++) {
						if (arr[j] == '+') {
							map[tempX + subX, tempY + subY] = true;
							subY++;
						} else if (arr[i] == '\n') {
							subX--;
						}
					}
				}
			}
			for (int i = 0; i < Globals.boardSize; i++) {
				for (int j = 0; j < Globals.boardSize; j++) {
					if (map[j, i] == false) {
						Console.Write("O ");
					} else {
						Console.Write("# ");
					}
				}
				Console.WriteLine();
			}
		}

		private bool CheckPos(int x, int y) {
			if (x < 0 || y < 0) {
				return false;
			}
			if (x >= Globals.boardSize || y >= Globals.boardSize) {
				return false;
			}
			int subX, subY, tempX, tempY;
			for (int i = 0;i < placedEntities.Count;i++) {
				tempX = placedEntities[i].x;
				tempY = placedEntities[i].y;
				subX = subY = 0;
				char[] arr = placedEntities[i].layout.ToCharArray();
				for (int j = 0; j < arr.Length; j++) {
					if (arr[j] == '+') {
						if (x == tempX + subX && y == tempY + subY) {
							return false;
						}
						subX++;
					} else if (arr[i] == '\n') {
						subY++;
					}
				}
			}
			return true;
		}
	}
}
