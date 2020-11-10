using System;

namespace ArrayBasicsEx
{
	internal class Program
	{
		public static void Main ( string [] args )
		{
			char [] vowels = new char[ 5 ];
			vowels [ 0 ] = 'a';
			vowels [ 1 ] = 'e';
			vowels [ 2 ] = 'i';
			vowels [ 3 ] = 'o';
			vowels [ 4 ] = 'u';

			for ( int i = 0; i < vowels.Length; i++ )
				Console.Write ( vowels [ i ] );

			Console.WriteLine ();

			foreach ( char c in vowels )
				Console.Write ( c );
			
			/* Indices */
			char lastElement = vowels [ ^1 ];
			char secondToLast = vowels [ ^2 ];
			
			/* Ranges */
			Range firstTwoRange = 0..2;
			char [] firstTwo = vowels [ firstTwoRange ];		// 'a', 'e'
			char [] lastThree = vowels [ 2.. ];		// 'i', 'o', 'u'
			char [] middleOne = vowels [2..3];		// 'i'
		}
	}
}