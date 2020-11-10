using System;

namespace BooleanEx
{
	internal class Program
	{
		public static void Main ( string [] args )
		{
			bool simpleVar = false;
			if ( simpleVar )
				Console.WriteLine ("This will not print");

			int x = 5000;
			bool lessThanAMile = x < 5280;
			if ( lessThanAMile )
				Console.WriteLine ("This will print");
		}
	}
}