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
			return new GameBoard();
		}

		public void addFirstColor(Color _firstColor) {
			firstColor = _firstColor;
		}

		public void addSecondColor(Color _secondColor) {
			secondColor = _secondColor;
		}
	}
}
