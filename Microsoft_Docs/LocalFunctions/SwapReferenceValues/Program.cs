using System;

namespace SwapReferenceValues
{
	class Program
	{
		static void SwapByRef ( ref int x, ref int y )
		{
			int temp = x;
			x = y;
			y = temp;
		}
		
		static void Main ( string [] args )
		{
			int i = 2, j = 3;
			Console.WriteLine ( "i = {0} j = {1}", i, j );
			
			SwapByRef ( ref i, ref j );

			Console.WriteLine ( "i = {0} j = {1}", i, j );
			
			// Keep the console window open in debug mode.
			Console.ReadKey ();
		}
	}
}