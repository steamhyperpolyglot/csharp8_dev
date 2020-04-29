using System;

namespace DisplayCmdLineArgs
{ 
	class Program
	{
		public static void Main ( string [] args )
		{
			// The Length property provides the number of array elements.
			Console.WriteLine ( $"parameter count = {args.Length}" );

			for ( int i = 0; i < args.Length; i++ )
			{
				Console.WriteLine ($"Arg[{i}] = [{args[i]}]");
			}
		}
	}
}