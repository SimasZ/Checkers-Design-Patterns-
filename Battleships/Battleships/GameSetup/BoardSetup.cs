using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships {
	class BoardSetup {
		public static UnitLayoutFactory factory;

		public List<UnitLayout> unplacedEntities;
		public List<UnitData> placedEntities;

		public BoardSetup() {
			unplacedEntities = new List<UnitLayout>();
			unplacedEntities.Add(factory.GetLayout("xl_ship"));
			unplacedEntities.Add(factory.GetLayout("l_ship"));
			unplacedEntities.Add(factory.GetLayout("l_ship"));
			unplacedEntities.Add(factory.GetLayout("m_ship"));
			unplacedEntities.Add(factory.GetLayout("m_ship"));
			unplacedEntities.Add(factory.GetLayout("s_ship"));

			placedEntities = new List<UnitData>();
		}

		public bool TryPlace(string name, int x, int y, bool rotated) {
			for (int i = 0;i < unplacedEntities.Count;i++) {
				if (unplacedEntities[i].name == name) {
					UnitData ent = new UnitData(unplacedEntities[i], x, y, rotated);
					if (CheckForClearance(ent)) {
						placedEntities.Add(ent);
						unplacedEntities.RemoveAt(i);
						return true;
					}
					return false;
				}
			}
			Console.WriteLine("Unit with this name is not found.");
			return false;
		}

		public bool UnitsArePlaced() {
			return unplacedEntities.Count == 0;
		}

		private bool CheckForClearance(UnitData ent) {
			for (int i = 0; i < ent.positions.Count; i += 2) {
				if (!CheckPos(ent.positions[i], ent.positions[i+1])) {
					return false;
				}
			}
			return true;
		}

		public void PrintMap() {
			bool[,] map = new bool[Globals.boardSize, Globals.boardSize];
			for (int i = 0; i < placedEntities.Count; i++) {
				UnitData ent = placedEntities[i];
				for (int j = 0; j < ent.positions.Count; j+=2) {
					map[ent.positions[j], ent.positions[j+1]] = true;
				}
			}
			for (int i = 0; i < Globals.boardSize; i++) {
				for (int j = 0; j < Globals.boardSize; j++) {
					if (map[j, i] == false)
					{
					    Console.ForegroundColor = ConsoleColor.Blue;
						Console.Write("~ ");
                        Console.ResetColor();
					} else {
					    Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("+ ");
					    Console.ResetColor();
                    }
				}
				Console.WriteLine();
			}
		}

		private bool CheckPos(int x, int y) {
			if (x < 0 || y < 0) {
				Console.WriteLine("Cant place out of bounds");
				return false;
			}
			if (x >= Globals.boardSize || y >= Globals.boardSize) {
				Console.WriteLine("Cant place out of bounds");
				return false;
			}
			for (int i = 0; i < placedEntities.Count; i++) {
				UnitData ent = placedEntities[i];
				for (int j = 0; j < ent.positions.Count; j+=2) {
					if (x == ent.positions[j] && y == ent.positions[j+1]) {
						Console.WriteLine("Other unit is in this place " + x + " " + y);
						return false;
					}
				}
			}
			return true;
		}

		public string ToCommand() {
			string command = "opponentLayout " + placedEntities.Count + " ";
			for (int i = 0;i < placedEntities.Count;i++) {
				command += placedEntities[i].layout.name + " " + placedEntities[i].x + " " + placedEntities[i].y + " " + (placedEntities[i].rotated == true ? 1 : 0) + " ";
			}
			return command;
		}

		public Memento CreateMemento() {
			Memento memento = new Memento(this);
			return memento;
		}

		public void Restore(Memento memento) {
			unplacedEntities = memento.unplacedUnits;
			placedEntities = memento.placedUnits;
		}
	}
}
