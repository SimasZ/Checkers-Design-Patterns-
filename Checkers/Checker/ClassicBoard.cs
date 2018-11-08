using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Checkers.Checker.Prototype;


namespace Checkers.Checker {
	class ClassicBoard : GameBoard, IPrototype<ClassicBoard> {
		private int size;

		public ClassicBoard(Color firstColor, Color secondColor, int _size) : base(firstColor, secondColor){
			size = _size;
		}

	    public ClassicBoard Clone()
	    {
	        using (var memoryStream = new MemoryStream())
	        {
	            var formatter = new BinaryFormatter();
	            formatter.Serialize(memoryStream, this);
	            memoryStream.Position = 0;

	            return (ClassicBoard)formatter.Deserialize(memoryStream);
	        }
        }
	}
}
