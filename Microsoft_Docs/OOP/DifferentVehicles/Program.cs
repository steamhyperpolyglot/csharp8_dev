using System;
using System.Collections.Generic;

namespace DifferentVehicles
{ 
	internal class Program
	{
		public static void Main ( string [] args )
		{
			Console.WriteLine ( "\nTesting the different vehicle classes..." );
			Console.WriteLine ( "-----------------------------------------" );

			var cars = new List <Car>
			{
				new Car (),
				new ConvertibleCar (),
				new Minivan ()
			};

			foreach ( var car in cars )
			{
				car.DescribeCar ();
				Console.WriteLine ( "----------" );
			}
		}

		public void prevCodeExamples()
		{
			Console.WriteLine ( "\nTestCars1" );
			Console.WriteLine ( "----------");

			Car car1 = new Car ();
			car1.DescribeCar ();
			Console.WriteLine ( "----------" );
			
			// Notice the output from this test case. The new modifier is
			// used in the definition of ShowDetails in the ConvertibleCar
			// class.
			
			ConvertibleCar car2 = new ConvertibleCar ();
			car2.DescribeCar ();
			Console.WriteLine ( "----------" );
			
			Minivan car3 = new Minivan ();
			car3.DescribeCar ();
			Console.WriteLine ( "----------" );
		}
	}
}