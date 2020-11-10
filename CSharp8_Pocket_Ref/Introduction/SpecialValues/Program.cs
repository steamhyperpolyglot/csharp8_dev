using System;

namespace SpecialValues
{
	internal class Program
	{
		public static void Main ( string [] args )
		{
			Console.WriteLine ( double.NegativeInfinity );

			Console.WriteLine ( 1.0 / 0.0 );
			Console.WriteLine ( -1.0 / 0.0 );
			Console.WriteLine ( 1.0 / -0.0 );
			Console.WriteLine ( -1.0 / -0.0 );

			Console.WriteLine (0.0 / 0.0);
			Console.WriteLine ( ( 1.0 / 0.0 ) - ( 1.0 / 0.0 ) );

			Console.WriteLine ( 0.0 / 0.0 == double.NaN );
			Console.WriteLine ( double.IsNaN ( 0.0 / 0.0 ) );
		}
	}
}