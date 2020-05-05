namespace AbstractProperties
{
	public abstract class Shape
	{
		private string name;

		public Shape ( string s )
		{
			// calling the set accessor of the Id property.
			Id = s;
		}

		public string Id
		{
			get
			{
				return name;
			}

			set
			{
				name = value;
			}
		}

		public abstract double Area
		{
			get;
		}

		public override string ToString()
		{
			return $"{Id} Area = {Area:F2}";
		}
	}

	public class Square : Shape
	{
		private int side;

		public Square ( int side, string id ) : base(id)
		{
			this.side = side;
		}

		public override double Area
		{
			get
			{
				// Given by the side, return the area of a square.
				return side * side;
			}
		}
	}

	public class Circle : Shape
	{
		private int radius;

		public Circle ( int radius, string id ) : base ( id )
		{
			this.radius = radius;
		}

		public override double Area
		{
			get
			{
				// Given the radius, return the area of a circle.
				return radius * radius * System.Math.PI;
			}
		}
	}

	public class Rectangle : Shape
	{
		private int width;
		private int height;

		public Rectangle ( int width, int height, string id ) : base ( id )
		{
			this.width = width;
			this.height = height;
		}

		public override double Area
		{
			get
			{
				// Given the width and height, return the area of a rectangle
				return width * height;
			}
		}
	}
}