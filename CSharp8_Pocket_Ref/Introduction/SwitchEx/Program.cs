using System;

namespace SwitchEx
{
	internal class Program
	{
		static void ShowCard ( int cardNumber )
		{
			switch ( cardNumber )
			{
				case 13:
					Console.WriteLine ( "King" );
					break;
				case 12:
					Console.WriteLine ("Queen");
					break;
				case 11:
					Console.WriteLine ("Jack");
					break;
				default:
					Console.WriteLine (cardNumber);
					break;
			}
		}
		
		public static void Main ( string [] args )
		{
			
		}
	}
}