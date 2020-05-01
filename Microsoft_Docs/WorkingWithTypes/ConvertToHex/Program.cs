using System;

namespace ConvertToHex
{
	class Program
	{
		public static void Main ( string [] args )
		{
			string input = "Hello World!";
			char [] values = input.ToCharArray ();
			foreach ( char letter in values )
			{
				// Get the integral value of the character.
				int value = Convert.ToInt32 ( letter );
				// Convert the integer value to a hexadecimal value in string form.
				Console.WriteLine ( $"Hexadecimal value of {letter} is {value:X}" );
			}
		}
	}
}