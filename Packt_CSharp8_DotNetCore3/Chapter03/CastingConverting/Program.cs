﻿using System;
using static System.Console;
using static System.Convert;

namespace CastingConverting
{
	class Program
	{
		static void Main ( string [] args )
		{
			int a = 10;
			double b = a;
			WriteLine ( b );

			double c = 9.8;
			int d = (int) c;
			WriteLine(d);

			long e = 10;
			int f = ( int ) e;
			WriteLine($"e is {e:N0} and f is {f:N0}");
			e = 5_000_000_000;
			f = ( int ) e;
			WriteLine ( $"e is {e:N0} and f is {f:N0}" );

			double g = 9.8;
			int h = ToInt32 ( g );
			WriteLine($"g is {g} and h is {h}");

			double [] doubles = new [] { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };

			foreach ( double n in doubles )
			{
				// WriteLine($"ToInt({n}) is {ToInt32(n)}");
				WriteLine ( "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
					n,
					Math.Round ( n, 0, MidpointRounding.AwayFromZero ) );
			}

			int number = 12;
			WriteLine(number.ToString());
			bool boolean = true;
			WriteLine(boolean.ToString());
			DateTime now = DateTime.Now;
			WriteLine(now.ToString());
			object me = new object ();
			WriteLine(me.ToString ());
			
			WriteLine("\nConverting from binary object to string...");
			// allocate array of 128 bytes
			byte [] binaryObject = new byte[ 128 ];
			// populate array with random bytes
			(new Random()).NextBytes ( binaryObject );
			WriteLine("Binary Object as bytes:");
			for ( int index = 0; index < binaryObject.Length; index++ )
			{
				Write ( $"{binaryObject [ index ]:X} " );
			}

			WriteLine ();
			// convert to Base64 string and output as text
			string encoded = Convert.ToBase64String ( binaryObject );
			WriteLine($"Binary Object as Base 64: {encoded}");
			
			WriteLine("\nTime for us to parse some values...");
			int age = int.Parse ( "37" );
			DateTime birthday = DateTime.Parse ( "15 September 1982" );
			WriteLine($"I was born {age} years ago");
			WriteLine($"My birthday is {birthday}.");
			WriteLine($"My birthday is {birthday:D}.");
			
			WriteLine("\nNow we will use TryParse()...");
			Write ( "How many eggs are there? " );
			int count;
			string input = Console.ReadLine ();
			
			if (int.TryParse ( input, out count ))
			{
				WriteLine ( $"There are {count} eggs." );
			}
			else
			{
				WriteLine ( "I could not parse the input." );
			}
		}
	}
}