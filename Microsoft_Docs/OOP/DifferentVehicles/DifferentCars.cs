using System;

namespace DifferentVehicles
{
	// Define the base class, Car. The class defines two methods,
	// Describecar and ShowDetails. DescribeCar calls ShowDetails, and each derived
	// class also defines a ShowDetails method. The example tests which version of
	// ShowDetails is selected, the base class method or the derived class method.
	public class Car
	{
		public void DescribeCar()
		{
			Console.WriteLine ( "Four wheels and an engine." );
			ShowDetails ();
		}

		public virtual void ShowDetails()
		{
			Console.WriteLine ( "Standard transportation." );
		}
	}
	
	// Class ConvertibleCar uses the new modifier to acknowledge that ShowDetails
	// hides the base class method.
	class ConvertibleCar : Car
	{
		public override void ShowDetails()
		{
			Console.WriteLine ( "A roof that opens up." );
		}
	}
	
	// Class Minivan uses the override modifier to specify that ShowDetails
	// extends the base class method.
	class Minivan : Car
	{
		public override void ShowDetails()
		{
			Console.WriteLine ( "Carries seven people." );
		}
	}
}