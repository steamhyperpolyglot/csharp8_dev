using System;

namespace ConvertString
{ 
	class Program
	{
		public static void Main ( string [] args )
		{
			int numVal;
			bool repeat = true;

			while ( repeat )
			{
				Console.Write ("Enter a number between -2,147,483,648 and +2,147,483,647 (inclusive): "  );

				string input = Console.ReadLine ();
				
				// ToInt32 can throw FormatException or OverflowException.
				try
				{
					numVal = Convert.ToInt32 ( input );
					if ( numVal < Int32.MaxValue )
					{
						Console.WriteLine ( "The new value is {0}", ++numVal );
					}
					else
					{
						Console.WriteLine ( "numVal cannot be incremented beyond its current value" );
					}
				}
				catch ( FormatException )
				{
					Console.WriteLine ( "Input string is not a sequence of digits." );
				}
				catch ( OverflowException )
				{
					Console.WriteLine ( "The number cannot fit in an Int32." );
				}

				Console.Write ( "Go again? Y/N: " );
				string go = Console.ReadLine ();
				if ( go.ToUpper () != "Y" )
					repeat = false;
			}
		}
	}
}