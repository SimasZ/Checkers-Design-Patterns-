using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships {
	public class UnitData {
		public int x, y;
		public UnitLayout layout { get; private set; }
		public List<int> positions { get; private set; }
		public bool rotated { get; private set; }

		public UnitData(UnitLayout _layout, int _x, int _y, bool _rotated) {
				x = _x;
				y = _y;
				layout = _layout;
				rotated = _rotated;

				positions = new List<int>();
				int offsetX = 0, offsetY = 0;
				if (!_rotated) {
					for (int i = 0; i < _layout.layout.Length; i++) {
						if (_layout.layout[i] == '+') {
							positions.Add(x + offsetX);
							positions.Add(y + offsetY);
							offsetX++;
						}
					}
				} else {
					for (int i = 0; i < _layout.layout.Length; i++) {
						if (_layout.layout[i] == '+') {
							positions.Add(x + offsetX);
							positions.Add(y + offsetY);
							offsetY++;
						}
					}
				}
			}
		}
	}
