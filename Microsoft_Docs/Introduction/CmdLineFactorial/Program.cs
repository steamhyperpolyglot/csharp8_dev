﻿using System;

namespace CmdLineFactorial
{
	public class Functions
	{
		public static long Factorial ( int n )
		{
			// Test for invalid input.
			if ( n < 0 || n > 20 )
			{
				return -1;
			}
			
			// Calculate the factorial iteratively rather than recursively
			long tempResult = 1;
			for ( int i = 1; i <= n; i++ )
			{
				tempResult *= i;
			}

			return tempResult;
		}
	}
	
	class Program
	{
		static int Main ( string [] args )
		{
			// Test if input arguments were supplied.
			if ( args.Length == 0 )
			{
				Console.WriteLine ( "Please enter a numeric argument." );
				Console.WriteLine ( "Usage: Factorial <num>" );
				return 1;
			}

			// Try to convert the input arguments to numbers. This will throw
			// an exception if the argument is not a number.
			int num;
			bool test = int.TryParse ( args [ 0 ], out num );
			if ( !test )
			{
				Console.WriteLine ( "Please enter a numeric argument." );
				Console.WriteLine ( "Usage: Factorial <num>" );
				return 1;
			}

			// Calculate Factorial
			long result = Functions.Factorial ( num );

			// Print result.
			if ( result == -1 )
				Console.WriteLine ( "Input must be >= 0 and <= 20" );
			else
				Console.WriteLine ( $"The Factorial of {num} is {result}." );

			return 0;
		}
	}
}