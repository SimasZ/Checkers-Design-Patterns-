using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.Checker {
	class RandomBoard : GameBoard{
		private int width, height;

		public RandomBoard(Color firstColor, Color secondColor, int _width, int _height) : base(firstColor, secondColor) {
			width = _width;
			height = _height;
		}
	}
}
