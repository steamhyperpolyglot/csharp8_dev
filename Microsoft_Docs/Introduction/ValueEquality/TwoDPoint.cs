﻿using System;

namespace ValueEquality
{
	public class TwoDPoint : IEquatable <TwoDPoint>
	{
		// Read-only auto-implemented properties
		public int X { get; private set; }
		public int Y { get; private set; }

		// Set the properties in the constructor.
		public TwoDPoint ( int x, int y )
		{
			if ( ( x < 1 ) || ( x > 2000 ) || ( y < 1 ) || ( y > 2000 ) )
			{
				throw new ArgumentException("Point must be in range 1 - 2000");
			}

			this.X = x;
			this.Y = y;
		}

		public bool Equals ( TwoDPoint p )
		{
			// If parameter is null, return false.
			if ( Object.ReferenceEquals ( p, null ) )
			{
				return false;
			}
			
			// Optimization for a common success case.
			if ( Object.ReferenceEquals ( this, p ) )
			{
				return true;
			}
			
			// If run-time types are not exactly the same, return false
			if ( this.GetType () != p.GetType () )
			{
				return false;
			}
			
			// Return type if the fields match.
			// Note that the base class is not invoked because it is
			// System.Object, which defines Equals as reference equality.
			return ( X == p.X ) && ( Y == p.Y );
		}

		public override int GetHashCode()
		{
			return X * 0x00010000 + Y;
		}

		public static bool operator == ( TwoDPoint lhs, TwoDPoint rhs )
		{
			// Check for null on left side
			if ( Object.ReferenceEquals ( lhs, null ) )
			{
				if ( Object.ReferenceEquals ( rhs, null ) )
				{
					// null == null = true
					return true;
				}
				
				// Only the left side is null.
				return false;
			}
			
			// Equals handles case of null on right side.
			return lhs.Equals ( rhs );
		}

		public static bool operator != ( TwoDPoint lhs, TwoDPoint rhs )
		{
			return !( lhs == rhs );
		}
	}
}