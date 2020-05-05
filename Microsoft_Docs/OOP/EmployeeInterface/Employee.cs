namespace EmployeeInterface
{
	public class Employee : IEmployee
	{
		public static int numberOfEmployees;

		private string _name;

		public string Name
		{
			get => _name;
			set => _name = value;
		}

		private int _counter;

		public int Counter
		{
			get => _counter;
		}
		
		// constructor
		public Employee() => _counter = ++numberOfEmployees;
	}
}