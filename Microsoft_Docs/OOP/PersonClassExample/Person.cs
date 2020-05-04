using System;

namespace PersonClassExample
{
	class Person
	{
		public string Name { get; }

		// Constructor that takes no arguments.
		public Person()
		{
			Name = "Unknown";
		}

		// Constructor that takes one argument:
		public Person(string name)
		{
			Name = name;
		}

		// Method that overrides the base class (System.Object) implementation.
		public override string ToString()
		{
			return Name;
		}
	}
}
