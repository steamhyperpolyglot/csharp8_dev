using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingGuide
{
	public class CustomClass
	{
		// Property
		public int Number { get; set; }

		// Method
		public int Multiply(int num)
		{
			return num * Number;
		}

		// Instance constructor
		public CustomClass()
		{
			Number = 0;
		}
	}

	class Program
	{
		static void Main ( string [] args )
		{
			// Create an object of type CustomClass.
			CustomClass custClass = new CustomClass();

			// Set the value of the public property.
			custClass.Number = 27;

			// Call the public method.
			int result = custClass.Multiply(4);
			Console.WriteLine($"The result is {result}.");

			Console.WriteLine("Press any key to EXIT...");
			Console.ReadKey();
		}
	}
}
