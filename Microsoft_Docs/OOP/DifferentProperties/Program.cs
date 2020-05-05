using System;

namespace DifferentProperties
{
	public class Employee
	{
		public static int NumberOfEmployees;
		private static int _counter;
		private static string _name;
		
		// A read-write instance property:
		public string Name
		{
			get => _name;
			set => _name = value;
		}
		
		// A read-only static property:
		public static int Counter => _counter;
		
		// A Constructor
		public Employee() => _counter = ++NumberOfEmployees;	// Calculate the employee's number
	}

	public class Manager : Employee
	{
		private string _name;
		
		// Notice the use of the new modifier
		public new string Name
		{
			get => _name;
			set => _name = value + ", Manager";
		}
	}

	class Program
	{
		public static void Main ( string [] args )
		{
			Employee.NumberOfEmployees = 107;
			Employee e1 = new Employee ();
			e1.Name = "Claude Vige";

			Console.WriteLine ( "Employee number: {0}", Employee.Counter );
			Console.WriteLine ( "Employee name: {0}", e1.Name );

			Manager m1 = new Manager ();
			
			// Derived class property.
			m1.Name = "John";
			
			// Base class property.
			( ( Employee ) m1 ).Name = "Mary";

			Console.WriteLine ( "Name in the derived class is: {0}", m1.Name );
			Console.WriteLine ( "name in the base class is: {0}", ((Employee) m1).Name );
		}
	}
}