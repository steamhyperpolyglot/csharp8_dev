using System;

namespace WorkingWithStrings
{
	internal class Program
	{ 
		public static void Main ( string [] args )
		{
			string message = "Hello world";
			string upperMessage = message.ToUpper ();
			Console.WriteLine (upperMessage);

			int x = 2015;
			message = message + x.ToString ();
			Console.WriteLine ( message );
		}
	}
}