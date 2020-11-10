using System;

namespace StringInterpolation
{
	internal class Program
	{
		public static void Main ( string [] args )
		{
			int x = 4;
			Console.Write ( $"A square has {x} sides\n" );
			string s = $"15 in hex is {15:X2}";
			Console.WriteLine ( s );
		}
	}
}