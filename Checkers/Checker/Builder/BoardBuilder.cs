using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.Checker.Builder {
	class BoardBuilder {
		private Color firstColor, secondColor;

		public GameBoard getBoard(int width, int height) {
			if (width == height) {
				return new ClassicBoard(firstColor, secondColor, width);
			} else {
				return new RandomBoard(firstColor, secondColor, width, height);
			}
		}

		public void addFirstColor(Color _firstColor) {
			firstColor = _firstColor;
		}

		public void addSecondColor(Color _secondColor) {
			secondColor = _secondColor;
		}
	}
}
