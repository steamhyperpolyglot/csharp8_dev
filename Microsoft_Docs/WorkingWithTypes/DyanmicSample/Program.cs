﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyanmicSample
{
	class Program
	{
		static void Main ( string [] args )
		{
			dynamic rFile = new ReadOnlyFile(@"..\..\TextFile1.txt");
			foreach (string line in rFile.Customer)
			{
				Console.WriteLine(line);
			}
			Console.WriteLine("-------------------------------");
			foreach (string line in rFile.Customer(StringSearchOption.Contains, true))
			{
				Console.WriteLine(line);
			}

			Console.WriteLine("Press any key to EXIT...");
			Console.ReadKey();
		}
	}
}
