﻿using System;

namespace ClassInstances
{
	public class Person
	{
		public string Name { get; set; }
		public int Age { get; set; }

		public Person ( string name, int age )
		{
			Name = name;
			Age = age;
		}
	}
	
	class Program
	{
		public static void Main ( string [] args )
		{
			Person person1 = new Person ( "Leopold", 6 );
			Console.WriteLine ( "person1 Name = {0} Age = {1}", person1.Name, person1.Age );
			
			// Declare new person, assign person1 to it.
			Person person2 = person1;
			
			// Change the name of person2, and person1 also changes.
			person2.Name = "Molly";
			person2.Age = 16;

			Console.WriteLine ( "person2 Name = {0} Age = {1}", person2.Name, person2.Age );
			Console.WriteLine ( "person1 Name = {0} Age = {1}", person1.Name, person1.Age );
			
			// Keep the console open in debug mode.
			Console.WriteLine ( "Press any key to exit." );
			Console.ReadKey ();
		}
	}
}