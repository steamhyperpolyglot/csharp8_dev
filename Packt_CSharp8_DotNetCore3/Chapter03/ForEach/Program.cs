using static System.Console;

namespace ForEach
{
	class Program
	{
		static void Main ( string [] args )
		{
			string [] names = { "Adam", "Barry", "Charlie" };
			foreach ( string name in names )
			{
				WriteLine($"{name} has {name.Length} characters.");
			}
		}
	}
}