using System;

namespace IncrementDecrement
{
	internal class Program
	{
		public static void Main ( string [] args )
		{
			int x = 0;

			Console.WriteLine ( x++ );
			Console.WriteLine ( ++x );
			Console.WriteLine ( --x );
		}
	}
}