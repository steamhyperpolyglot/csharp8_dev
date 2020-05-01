using System;

namespace HexToChar
{
	class Program
	{
		public static void Main ( string [] args )
		{
			string hexValues = "48 65 6C 6C 6F 20 57 6F 72 6C 64 21";
			string [] hexValuesSplit = hexValues.Split ( ' ' );
			foreach ( string hex in hexValuesSplit )
			{
				// Convert the number expressed in base-16 to an integer.
				int value = Convert.ToInt32 ( hex, 16 );
				// Get the character corresponding to the integral value.
				string stringValue = Char.ConvertFromUtf32 ( value );
				char charValue = ( char ) value;
				Console.WriteLine ( "hexadecimal value = {0}, int value = {1}, char value = {2} or {3}", 
					hex, value, stringValue, charValue );
			}
		}
	}
}