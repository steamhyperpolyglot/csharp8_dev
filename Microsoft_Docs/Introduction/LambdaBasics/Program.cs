using System;
using System.Linq;

namespace LambdaBasics
{ 
	internal class Program
	{
		public static void Main ( string [] args )
		{
			int [] numbers = { 2, 3, 4, 5 };
			var squaredNumbers = numbers.Select ( x => x * x );
			Console.WriteLine ( string.Join ( " ", squaredNumbers ) );
			
			// Statement lambdas
			Action <string> greet = name =>
			{
				string greeting = $"Hello {name}!";
				Console.WriteLine ( greeting );
			};

			greet ( "World" );
		}
	}
}