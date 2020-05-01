using System;

namespace ExplicitConversion
{ 
	internal class Program
	{
		public static void Main ( string [] args )
		{
			double x = 1234.7;
			int a;
			// Cast double to int.
			a = ( int ) x;
			Console.WriteLine(a);
		}
	}
}