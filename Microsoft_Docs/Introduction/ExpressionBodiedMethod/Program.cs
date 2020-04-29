using System;

namespace ExpressionBodiedMethod
{ 
	internal class Program
	{
		public static void Main ( string [] args )
		{
			Person p = new Person ( "Mandy", "Dejesus" );
			Console.WriteLine ( p );
			p.DisplayName ();
		}
	}
}