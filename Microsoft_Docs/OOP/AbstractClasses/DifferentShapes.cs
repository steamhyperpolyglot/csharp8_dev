using System;

namespace AbstractClasses
{
	abstract class Shape
	{
		public abstract double Area
		{
			get;
			set;
		}
	}

	class Square : Shape
	{
		public double side;
		
		// constructor
		public Square ( double s ) => side = s;

		public override double Area
		{
			get => side * side;
			set => side = Math.Sqrt ( value );
		}
	}

	class Cube : Shape
	{
		public double side;
		
		// constructor
		public Cube ( double s ) => side = s;

		public override double Area
		{
			get => 6 * side * side;
			set => side = Math.Sqrt ( value / 6 );
		}
	}
}