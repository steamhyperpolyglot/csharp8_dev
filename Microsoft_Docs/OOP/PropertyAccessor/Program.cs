using System;

namespace PropertyAccessor
{
	public class BaseClass
	{
		private string _name = "Name-BaseClass";
		private string _id = "ID-BaseClass";

		public string Name
		{
			get { return _name; }
			set {}
		}

		public string Id
		{
			get { return _id; }
			set { }
		}
	}

	public class DerivedClass : BaseClass
	{
		private string _name = "Name-DerivedClass";
		private string _id = "ID-DerivedClass";

		new public string Name
		{
			get
			{
				return _name;
			}
			
			// Using "protected" would make the set accessor not accessible
			set
			{
				_name = value;
			}
		}
		
		// Using private on the following property hides it in the Main Class.
		// Any assignment to the property will use Id in BaseClass.
		new private string Id
		{
			get
			{
				return _id;
			}

			set
			{
				_id = value;
			}
		}
	}
	
	class Program
	{
		public static void Main ( string [] args )
		{
			BaseClass b1 = new BaseClass ();
			DerivedClass d1 = new DerivedClass ();

			b1.Name = "Mary";
			d1.Name = "John";

			b1.Id = "Mary123";
			d1.Id = "John123";	// the BaseClass.Id property is called.

			Console.WriteLine ( "Base: {0}, {1}", b1.Name, b1.Id );
			Console.WriteLine ( "Derived: {0}, {1}", d1.Name, d1.Id );
			
			// Keep the console window open in debug mode.
			Console.WriteLine ( "Press any key to exit..." );
			Console.ReadKey ();
		}
	}
}