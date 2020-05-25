using System;

namespace StatementsExpressions
{
	class Program
	{
		static void Main ( string [] args )
		{
			// Some statements...
			int a = 19;
			int b = 23;
			int c;
			c = a + b;
			Console.WriteLine(c);

			// Some expressions...
			double doubleA = 1, doubleB = 2.5, doubleC = -3;
			double x = (-doubleB + Math.Sqrt(doubleB * doubleB - 4 * doubleA * doubleC)) / (2 * doubleA);
			Console.WriteLine(x);

			// Assignments are expressions
			int number;
			Console.WriteLine(number = 123);
			Console.WriteLine(number);

			int y, z;
			y = z = 0;
			Console.WriteLine(y);
			Console.WriteLine(z);
		}
	}
}
