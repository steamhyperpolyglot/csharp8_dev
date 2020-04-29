using System;

namespace ExpressionBodiedUsages
{
	public class Location
	{
		private string locationName;

		// Expression Bodied Constructors
		public Location ( string name ) => Name = name;

		// Expression Bodied Read-only Property
		//public string Name => locationName;
		
		// Properties with get/set
		public string Name
		{
			get => locationName;
			set => locationName = value;
		}
		
		// Expression Bodied Finalizers
		~Location() => Console.WriteLine ( $"The Location destructor is executing." );
	}

	internal class Program
	{
		public static void Main ( string [] args )
		{
		}
	}
}