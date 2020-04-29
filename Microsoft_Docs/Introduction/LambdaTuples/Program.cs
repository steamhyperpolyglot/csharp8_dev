using System;

namespace LambdaTuples
{ 
	internal class Program
	{
		public static void Main ( string [] args )
		{
			Func <(int, int, int), (int, int, int)> doubleThem = ns => ( 2 * ns.Item1, 2 * ns.Item2, 2 * ns.Item3 );
			var numbers = ( 2, 3, 4 );
			var doubledNumbers = doubleThem ( numbers );
			Console.WriteLine ( $"The set {numbers} doubled: {doubledNumbers}" );
		}
	}
}