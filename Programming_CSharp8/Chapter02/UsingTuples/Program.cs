using System;
using System.Runtime.Intrinsics.X86;

namespace UsingTuples
{
	class Program
	{
		static void Main ( string [] args )
		{
			//(int X, int Y) point = ( 10, 5 );
			// We can also name tuple members in the initializer
			// var point = ( X: 10, Y: 5 );
			// How about inferring tuple member names from variables
			// int X = 10, Y = 5;
			// var point = ( X, Y );
			// Structural equivalence of tuples
			(int X, int Y) point = ( 46, 3 );
			(int Width, int Height) dimensions = point;
			(int Age, int NumberOfChildren) person = point;
			Console.WriteLine ( $"X: {point.X}, Y: {point.Y}" );
			
			// Deconstructing tuples
			( int x, int y ) = point;
			Console.WriteLine ( $"Deconstructed values - X: {x}, Y: {y}" );
		}
	}
}