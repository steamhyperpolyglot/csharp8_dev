using System.Collections.Generic;

namespace ShapePolymorphism
{
	internal class Program
	{
		public static void Main ( string [] args )
		{
			var shapes = new List <Shape>
			{
				new Rectangle (),
				new Triangle (),
				new Circle ()
			};
			
			// Polymorphism at work #: the virtual method Draw is
			// invoked on each of the derived classes, not the base class.
			foreach ( var shape in shapes )
			{
				shape.Draw ();
			}
		}
	}
}