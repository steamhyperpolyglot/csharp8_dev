using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClassExample
{
	class Program
	{
		static void Main ( string [] args )
		{
			// Call the constructor that has no parameters.
			var person1 = new Person();
			Console.WriteLine(person1.Name);

			// Call the constructor that has one parameter.
			var person2 = new Person("Sarah Jones");
			Console.WriteLine(person2.Name);
			// Get the string representation of the person2 instance.
			Console.WriteLine(person2);

			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}
	}
}
