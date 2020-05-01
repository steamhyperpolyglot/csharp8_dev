using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Scripting.Hosting;
using IronPython.Hosting;

namespace DynamicIronPythonSample
{
	class Program
	{
		static void Main ( string [] args )
		{
			// Set the current directory to the IronPython libraries.
			Directory.SetCurrentDirectory( @"C:\Program Files\IronPython 2.7\Lib" );

			// Create an instance of the random.py IronPython Library.
			Console.WriteLine("Loading random.py");
			ScriptRuntime py = Python.CreateRuntime();
			dynamic random = py.UseFile("random.py");
			Console.WriteLine("random.py loaded.");

			// Initialize an enumerable set of integers.
			int[] items = Enumerable.Range(1, 7).ToArray();

			// Randomly shuffle the array of integers by using IronPython.
			for (int i = 0; i < 5; i++)
			{
				random.shuffle(items);
				foreach (int item in items)
				{
					Console.WriteLine(item);
				}
				Console.WriteLine("--------------------");
			}

			Console.WriteLine("Press any key to EXIT...");
			Console.ReadKey();
		}
	}
}
