using System;
using static System.Console;

namespace ReturnValues
{
	class SimpleMath
	{
		public int AddTwoNumbers ( int number1, int number2 )
		{
			return number1 + number2;
		}

		public int SquareANumber ( int number )
		{
			return number * number;
		}
	}
	
	class Program
	{
		static void Main ( string [] args )
		{
			SimpleMath obj = new SimpleMath ();
			var result = obj.AddTwoNumbers ( 1, 2 );
			result = obj.SquareANumber ( result );
			Console.WriteLine ( result );
		}
	}
}