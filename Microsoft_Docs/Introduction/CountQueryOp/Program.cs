using System;
using System.Collections.Generic;
using System.Linq;

namespace CountQueryOp
{ 
	internal class Program
	{
		public static void Main ( string [] args )
		{
			int [] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
			int oddNumbers = numbers.Count(n => n % 2 == 1);
			Console.WriteLine ( $"There are {oddNumbers} odd numbers in {string.Join ( " ", numbers )}" );

			var firstNumbersLessThanSix = numbers.TakeWhile ( n => n < 6 );
			Console.WriteLine ( string.Join ( " ", firstNumbersLessThanSix ) );

			var firstSmallNumbers = numbers.TakeWhile ( ( n, index ) => n >= index );
			Console.WriteLine ( string.Join ( " ", firstSmallNumbers ) );
		}
	}
}