using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.Checker {
	class RandomBoard : GameBoard{
		private int width, height;

		public RandomBoard(Color firstColor, Color secondColor, int _width, int _height) : base(firstColor, secondColor) {
			width = _width;
			height = _height;
		}

	    public override object Clone()
	    {
	        using (var memoryStream = new MemoryStream())
	        {
	            var formatter = new BinaryFormatter();
	            formatter.Serialize(memoryStream, this);
	            memoryStream.Position = 0;

	            return (RandomBoard)formatter.Deserialize(memoryStream);
	        }
        }
	}
}
