using static System.Console;
using System.Xml;

namespace DoWhile
{
	class Program
	{
		static void Main ( string [] args )
		{
			string password = string.Empty;
			do
			{
				Write ( "Enter your password: " );
				password = ReadLine ();
			} while ( password != "Pa$$w0rd" );

			WriteLine ( "Correct!" );
		}
	}
}