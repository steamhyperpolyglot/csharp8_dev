﻿using System;

namespace EmployeeInterface
{
	class Program
	{
		public static void Main ( string [] args )
		{
			Console.Write ( "Enter number of employees: " );
			Employee.numberOfEmployees = int.Parse ( Console.ReadLine () );
			
			Employee e1 = new Employee ();
			Console.Write ( "Enter the name of the new employee: " );
			e1.Name = Console.ReadLine ();

			Console.WriteLine ( "The employee information:" );
			Console.WriteLine ( "Employee number: {0}", e1.Counter );
			Console.WriteLine ( "Employee number: {0}", e1.Name );
		}
	}
}