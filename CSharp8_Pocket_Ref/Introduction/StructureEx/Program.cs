using System;
using StructureEx;

namespace StructureEx
{
	public struct Point
	{
		public int X, Y;
	}
	
	internal class Program
	{
		public static void Main ( string [] args )
		{
			Point p1 = new Point { X = 7 };

			Point p2 = p1;

			Console.WriteLine ( p1.X );
			Console.WriteLine ( p2.X );

			p1.X = 9;						// Change p1.X
			Console.WriteLine ( p1.X );		// 9
			Console.WriteLine ( p2.X );		// 7
		}
	}
}