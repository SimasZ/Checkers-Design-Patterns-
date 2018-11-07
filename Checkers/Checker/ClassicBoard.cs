using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checkers.Net;


namespace Checkers.Checker {
	class ClassicBoard : GameBoard {
		private int size;

		public ClassicBoard(Color firstColor, Color secondColor, int _size) : base(firstColor, secondColor){
			size = _size;
		}
	}
}
