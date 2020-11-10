using System;

namespace ForEachEx
{
	class Program
	{
		static void Main ( string [] args )
		{
			foreach ( char c in "beer" )
				Console.WriteLine ( c + " " );
		}
	}
}