using System;

namespace CustomTypesEx
{
	public class UnitConverter
	{
		private int ratio;							// Field

		public UnitConverter ( int unitRatio )		// Constructor
		{
			ratio = unitRatio;
		}

		public int Convert ( int unit )			// Method
		{
			return unit * ratio;
		}
	}
	
	internal class Program
	{
		public static void Main ( string [] args )
		{
			UnitConverter feetToInches = new UnitConverter ( 12 );
			UnitConverter milesToFeet = new UnitConverter ( 5280 );

			Console.WriteLine ( feetToInches.Convert ( 30 ) );
			Console.WriteLine ( feetToInches.Convert ( 100 ) );
			Console.WriteLine ( feetToInches.Convert ( milesToFeet.Convert ( 1 ) ) );
		}
	}
}