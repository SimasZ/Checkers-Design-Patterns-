using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships {
	public class UnitLayout {
		public enum Type { Ship };

		public string name { get; private set; }
		public char[] layout { get; private set; }
		public string layoutStr { get; private set; }
		
		public Type type { get; private set; }

		public UnitLayout(string _name) {
			name = _name;
		}

		public void Setup(Type _type, string _layout) {
			if (layout != null) {
				return;
			}
			type = _type;
			layout = _layout.ToCharArray();
			layoutStr = _layout;
		}
	}
}
