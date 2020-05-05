namespace AutoImplementedProperties
{
	// This class is immutable. After an object is created,
	// it cannot be modified from outside the class. It uses a
	// constructor to initialize its properties.
	public class Contact
	{
		// Read-only property
		public string Name { get; }
		
		// Read-write property with a private set accessor.
		public string Address { get; private set; }
		
		// Public constructor.
		public Contact ( string contactName, string contactAddress )
		{
			Name = contactName;
			Address = contactAddress;
		}
	}

	// This class is immutable. After an object is created,
	// it cannot be modified from outside the class. It uses
	// a static method and private constructor to initialize
	// its properties.
	public class Contact2
	{
		// Read-write property with a private set accessor.
		public string Name { get; private set; }
		
		// Read-only property.
		public string Address { get; }
		
		// Private constructor.
		private Contact2 ( string contactName, string contactAddress )
		{
			Name = contactName;
			Address = contactAddress;
		}
		
		// Public factory method.
		public static Contact2 CreateContact ( string name, string address )
		{
			return new Contact2 ( name, address );
		}
	}
}