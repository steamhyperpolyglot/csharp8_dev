using System;
using System.Threading.Tasks;

namespace AsyncReturnValues
{
	class Program
	{
		static async Task<int> Main ( string [] args )
		{
			return await AsyncConsoleWork ();
		}

		private static async Task <int> AsyncConsoleWork()
		{
			return 0;
		}
	}
}