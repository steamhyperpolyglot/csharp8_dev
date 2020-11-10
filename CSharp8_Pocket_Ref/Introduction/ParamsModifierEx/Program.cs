using System;

namespace ParamsModifierEx
{
	internal class Program
	{
		static int Sum ( params int [] ints )
		{
			int sum = 0;
			for ( int i = 0; i < ints.Length; i++ )
				sum += ints [ i ];
			return sum;
		}
		
		public static void Main ( string [] args )
		{
			Console.WriteLine ( Sum ( 1, 2, 3, 4 ) );
		}
	}
}