using System;

namespace GotoEx
{
	class Program
	{
		static void Main ( string [] args )
		{
			int i = 1;
			startLoop:
			if ( i <= 5 )
			{
				Console.Write (i + " ");
				i++;
				goto startLoop;
			}
		}
	}
}