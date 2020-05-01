using System;

namespace UnSafeCasting
{
	class Animal
	{
		public void Eat()
		{
			Console.WriteLine("Eating.");
		}

		public override string ToString()
		{
			return "I am an animal";
		}
	}
	
	class Reptile : Animal {}

	class Mammal : Animal {}
	
	class Program
	{
		public static void Main ( string [] args )
		{
			// Keep the console window open in debug mode.
			Console.WriteLine ("Press any key to exit.");
			Console.ReadKey ();
		}

		static void Test ( Animal a )
		{
			// Cause InvalidCastException at run time
			// because Mammal is not convertible to Reptile
			Reptile r = (Reptile) a;
		}
	}
}