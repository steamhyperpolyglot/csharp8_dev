using System;

namespace PassingByVal
{
	class Program
	{
		static void SquareIt ( int x )
		{
			x *= x;
			Console.WriteLine ( "The value inside the method: {0}", x );
		}
		
		static void Main ( string [] args )
		{
			int n = 5;
			Console.WriteLine ( "The value before calling the method: {0}", n );

			SquareIt ( n );
			Console.WriteLine ( "The value after calling the method: {0}", n );
			
			// Keep the console window open in debug mode.
			Console.WriteLine ( "Press any key to exit." );
			Console.ReadKey ();
		}
	}
}