using System;

namespace PassingParameters
{
	class Program
	{
		static void Main ( string [] args )
		{
			int arg;
			
			// Passing by value.
			arg = 4;
			squareVal ( arg );
			Console.WriteLine ( arg );
			
			// Passing by reference.
			// The value of arg in Main is changed.
			arg = 4;
			squareRef ( ref arg );
			Console.WriteLine ( arg );
		}

		static void squareVal ( int valParameter )
		{
			valParameter *= valParameter;
		}
		
		// Passing by reference
		static void squareRef ( ref int refParameter )
		{
			refParameter *= refParameter;
		}
	}
}