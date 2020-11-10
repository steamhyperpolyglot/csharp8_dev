using System;
using System.Text;

namespace RefModifierEx
{
	internal class Program
	{
		static void Foo ( ref int p )
		{
			p = p + 1;
			Console.WriteLine ( p );
		}
		
		public static void Main ( string [] args )
		{
			int x = 8;
			Foo ( ref x );				// Pass x by reference
			Console.WriteLine ( x );	// x is now 9
		}
	}
}