using System;

namespace ExpressionBodiedMethod
{
	public class Person
	{
		public Person ( string firstName, string lastName )
		{
			fname = firstName;
			lname = lastName;
		}

		private string fname;
		private string lname;

		public override string ToString() => $"{fname}, {lname}".Trim();
		public void DisplayName() => Console.WriteLine ( ToString () );
	}
}