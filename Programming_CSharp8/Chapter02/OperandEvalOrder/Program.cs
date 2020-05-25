using System;

namespace OperandEvalOrder
{
	class Program
	{
		static int X ( string label, int i )
		{
			Console.Write ( label );
			return i;
		}
		
		static void Main ( string [] args )
		{
			Console.WriteLine ( X ( "a", 1 ) + X ( "b", 2 ) + X ( "c", 3 ) + X ( "d", 4 ) );
		}
	}
}