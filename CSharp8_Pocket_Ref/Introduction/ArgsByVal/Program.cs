using System;

namespace ArgsByVal
{
	internal class Program
	{
		static void Foo ( int p )
		{
			p = p + 1;
			Console.WriteLine (p);
		}
		
		public static void Main ( string [] args )
		{
			int x = 8;
			Foo ( x );
			Console.WriteLine ( x );	// x will still be 8
		}
	}
}