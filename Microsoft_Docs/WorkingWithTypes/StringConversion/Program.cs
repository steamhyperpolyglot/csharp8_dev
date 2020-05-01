using System;

namespace StringConversion
{ 
	internal class Program
	{
		public static void Main ( string [] args )
		{
			string input = String.Empty;
			try
			{
				int result = Int32.Parse ( input );
				Console.WriteLine ( result );
			}
			catch ( FormatException )
			{
				Console.WriteLine ( $"Unable to parse '{input}'" );
			}

			try
			{
				int numVal = Int32.Parse ( "-105" );
				Console.WriteLine ( numVal );
			}
			catch ( FormatException e )
			{
				Console.WriteLine ( e.Message );
			}

			if ( Int32.TryParse ( "-105", out int j ) )
				Console.WriteLine ( j );
			else
				Console.WriteLine ( "String could not be parsed." );

			try
			{
				int m = Int32.Parse ( "abc" );
			}
			catch ( FormatException e )
			{
				Console.WriteLine ( e.Message );
			}

			string inputString = "abc";
			if ( Int32.TryParse ( inputString, out int numValue ) )
				Console.WriteLine ( inputString );
			else
				Console.WriteLine ( $"Int32.TryParse could not parse '{inputString}' to an int." );
		}
	}
}