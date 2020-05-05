using System;

namespace ExpressionBodies
{
	class Person
	{
		private string _firstName;
		private string _lastName;

		public Person ( string first, string last )
		{
			_firstName = first;
			_lastName = last;
		}

		public string Name => $"{_firstName} {_lastName}";
	}

	public class SaleItem
	{
		private string _name;
		private decimal _cost;

		public SaleItem ( string name, decimal cost )
		{
			_name = name;
			_cost = cost;
		}

		public string Name
		{
			get => _name;
			set => _name = value;
		}

		public decimal Price
		{
			get => _cost;
			set => _cost = value;
		}

	}
	
	internal class Program
	{
		public static void Main ( string [] args )
		{
			var person = new Person ( "Magnus", "Hedlund" );
			Console.WriteLine ( person.Name );
			
			var item = new SaleItem ( "Shoes", 19.95m );
			Console.WriteLine ( $"{item.Name}: sells for {item.Price:C2}" );
		}
	}
}