using System;
using System.Collections;

namespace StructValueEquality
{
	struct TwoDPoint : IEquatable <TwoDPoint>
	{
		// Read/write auto-implemented properties
		public int X { get; private set; }
		public int Y { get; private set; }

		public TwoDPoint ( int x, int y ) : this()
		{
			X = x;
			Y = y;
		}

		public override bool Equals ( object obj )
		{
			if ( obj is TwoDPoint )
			{
				return this.Equals ( ( TwoDPoint ) obj );
			}

			return false;
		}

		public bool Equals ( TwoDPoint p )
		{
			return ( X == p.X ) && ( Y == p.Y );
		}

		public override int GetHashCode()
		{
			return X ^ Y;
		}

		public static bool operator == ( TwoDPoint lhs, TwoDPoint rhs )
		{
			return lhs.Equals ( rhs );
		}

		public static bool operator != ( TwoDPoint lhs, TwoDPoint rhs )
		{
			return !( lhs.Equals ( rhs ) );
		}
	}
	
	class Program
	{
		public static void Main ( string [] args )
		{
			TwoDPoint pointA = new TwoDPoint(3, 4);
			TwoDPoint pointB = new TwoDPoint(3, 4);
			int i = 5;

			Console.WriteLine ( "pointA.Equals(pointB) = {0}", pointA.Equals ( pointB ) );
			Console.WriteLine ( "pointA == pointB = {0}", pointA == pointB );
			Console.WriteLine ( "Object.Equals(pointA, pointB) = {0}", Object.Equals ( pointA, pointB ) );
			Console.WriteLine ( "pointA.Equals(null) = {0}", pointA.Equals(null) );
			Console.WriteLine ( "(pointA ==  null) = {0}", pointA == null );
			Console.WriteLine ( "(pointA != null) = {0}", pointA != null );
			Console.WriteLine ( "pointA.Equals(i) = {0}", pointA.Equals ( i ) );

			// compare unboxed to boxed.
			ArrayList list = new ArrayList ();
			list.Add ( new TwoDPoint ( 3, 4 ) );
			Console.WriteLine ( "pointE.Equals(list[0]): {0}", pointA.Equals ( list [ 0 ] ) );
			
			// Compare nullable to nullable and to non-nullable
			TwoDPoint? pointC = null;
			TwoDPoint? pointD = null;
			Console.WriteLine ( "pointA == (pointC = null) = {0}", pointA ==  pointC );
			Console.WriteLine ( "pointC == pointD = {0}", pointC == pointD );

			TwoDPoint temp = new TwoDPoint ( 3, 4 );
			pointC = temp;
			Console.WriteLine ("pointA == (pointC = 3, 4) = {0}", pointA == pointC);

			pointD = temp;
			Console.WriteLine ("pointD == (pointC = 3, 4) = {0}", pointD == pointC);
			
			// Keep the console window open in debug mode.
			Console.WriteLine ("Press any key to exit.");
			Console.ReadKey ();
		}
	}
}