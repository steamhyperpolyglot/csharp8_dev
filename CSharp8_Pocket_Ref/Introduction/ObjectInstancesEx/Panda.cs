namespace ObjectInstancesEx
{
	public class Panda
	{
		public string Name;					// Instance field
		public static int Population;			// Static field

		public Panda ( string n )				// Constructor
		{
			Name = n;							// Assign instance field
			Population = Population + 1;		// Increment static field
		}
	}
}