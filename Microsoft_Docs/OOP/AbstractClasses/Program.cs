using System;

namespace AbstractClasses
{
	internal class Program
	{
		public static void Main ( string [] args )
		{
			Console.Write ( "Enter the side: " );
			double side = double.Parse ( Console.ReadLine () );
			
			// Compute the areas:
			Square s = new Square ( side );
			Cube c = new Cube ( side );
			
			// Display the results:
			Console.WriteLine ( "Area of the square = {0:F2}", s.Area );
			Console.WriteLine ("Area of the cube = {0:F2}", c.Area);
			Console.WriteLine ();
			
			// Input the area:
			Console.Write ( "Enter the area: " );
			double area = double.Parse ( Console.ReadLine () );
			
			// Compute the sides:
			s.Area = area;
			c.Area = area;
			
			// Display the results:
			Console.WriteLine ( "Side of the square = {0:F2}", s.side );
			Console.WriteLine ( "Side of the cube = {0:F2}", c.side );
		}
	}
}