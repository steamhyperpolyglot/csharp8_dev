using System;

namespace CasesStacked
{
	internal class Program
	{
		public static void Main ( string [] args )
		{
			switch ( x )
			{
				case float f when f > 1000:
				case double d when d > 1000:
				case decimal m when m > 1000:
					Console.WriteLine ("f, d, and m are out of scope");
					break;
			}
		}
	}
}