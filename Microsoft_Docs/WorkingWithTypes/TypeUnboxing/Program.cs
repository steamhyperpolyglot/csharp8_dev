using System;

namespace TypeUnboxing
{ 
	class Program
	{
		public static void Main ( string [] args )
		{
			int i = 123;
			object o = i;	// implicit boxing

			try
			{
				int j = ( short ) o;

				Console.WriteLine ( "Unboxing OK." );
			}
			catch ( InvalidCastException e )
			{
				Console.WriteLine ( "{0} Error: Incorrect unboxing.", e.Message );
			}
		}
	}
}