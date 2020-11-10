using System;

namespace BreakEx
{
	class Program
	{
		static void Main ( string [] args )
		{
			int x = 0;

			while ( true )
			{
				if ( x++ > 5 ) break;		// break from the loop
			}
			
			// execution continues here after break
			// ...
		}
	}
}