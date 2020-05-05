using System;

namespace OverridingToString
{
	class Person
	{
		public string Name { get; set; }
		public int Age { get; set; }

		public override string ToString()
		{
			return "Person: " + Name + " " + Age;
		}
	}
	
	internal class Program
	{
		public static void Main ( string [] args )
		{
			Person person = new Person { Name = "John", Age = 12 };
			Console.WriteLine ( person );
		}
	}
}