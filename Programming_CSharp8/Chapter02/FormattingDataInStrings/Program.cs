using System;

namespace FormattingDataInStrings
{
	class Program
	{
		static void Main ( string [] args )
		{
			double width = 3, height = 4;
			// string info = $"Hypotenuse: {Math.Sqrt ( width * width + height * height )}";
			string info = string.Format ( "Hypotenuse: {0}", Math.Sqrt ( width * width + height * height ) );
			Console.WriteLine ( info );
		}
	}
}