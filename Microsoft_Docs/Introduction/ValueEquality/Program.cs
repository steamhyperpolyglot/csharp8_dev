using System;
using System.Collections;

namespace ValueEquality
{ 
	class Program
	{
		public static void Main ( string [] args )
		{
			ThreeDPoint pointA = new ThreeDPoint ( 3, 4, 5 );
			ThreeDPoint pointB = new ThreeDPoint ( 3, 4, 5 );
			ThreeDPoint pointC = null;
			int i = 5;

			Console.WriteLine ("pointA.Equals(pointB) = {0}", pointA.Equals ( pointB ));
			Console.WriteLine ( "pointA == pointB = {0}", pointA == pointB );
			Console.WriteLine ( "null comparison = {0}", pointA.Equals ( pointC ) );
			Console.WriteLine ( "Compare to some other type = {0}", pointA.Equals ( i ) );

			TwoDPoint pointD = null;
			TwoDPoint pointE = null;

			Console.WriteLine ( "Two null TwoDPoints are equal: {0}", pointD == pointE );
			
			pointE = new TwoDPoint ( 3, 4 );
			Console.WriteLine ( "(pointE == pointA) = {0}", pointE == pointA );
			Console.WriteLine ( "(pointA == pointE) = {0}", pointA == pointE );
			Console.WriteLine ( "(pointA != pointE) = {0}", pointA != pointE );

			ArrayList list = new ArrayList ();
			list.Add ( new ThreeDPoint ( 3, 4, 5 ) );
			Console.WriteLine ( "pointE.Equals(list[0]): {0}", pointE.Equals ( list [ 0 ] ) );
			
			// Keep the console window open in debug mode.
			Console.WriteLine ( "Press any key to exit." );
			Console.ReadKey ();
		}
	}
}