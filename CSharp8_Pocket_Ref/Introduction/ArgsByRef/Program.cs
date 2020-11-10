using System;
using System.Text;

namespace ArgsByRef
{
	internal class Program
	{
		static void Foo ( StringBuilder fooSB )
		{
			fooSB.Append ( "test" );
			fooSB = null;
		}
		
		public static void Main ( string [] args )
		{
			StringBuilder sb = new StringBuilder ();
			Foo ( sb );
			Console.WriteLine ( sb.ToString () );
		}
	}
}