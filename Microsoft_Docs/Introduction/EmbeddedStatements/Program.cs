using System;

namespace EmbeddedStatements
{ 
	internal class Program
	{
		public static void Main ( string [] args )
		{
			// Recommended style. Embedded statement in block.
			foreach ( string s in System.IO.Directory.GetDirectories ( System.Environment.CurrentDirectory ) )
			{
				Console.WriteLine ( s );
			}

			// Not recommended.
			foreach ( string s in System.IO.Directory.GetDirectories ( System.Environment.CurrentDirectory ) )
				Console.WriteLine ( s );
		}
	}
}