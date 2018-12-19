using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships {
	class UnitLayoutFactory {
		IDictionary<string, UnitLayout> cache = new Dictionary<string, UnitLayout>();

		public UnitLayout GetLayout(string name) {
			UnitLayout ret;
			if (!cache.TryGetValue(name, out ret)) {
				ret = new UnitLayout(name);
				cache.Add(name, ret);
			}
			return ret;
		}
	}
}
