using System;
using System.Linq;

namespace AutoImplementedProperties
{
	internal class Program
	{
		public static void Main ( string [] args )
		{
			// some simple data sources.
			string [] names = { "Terry Adams", "Fadi Fakhouri", "Hanying Feng", "Ceasar Garcia", "Debra Garcia" };
			string [] addresses =
			{
				"123 Main St.",
				"345 Cypress Ave.",
				"678 1st Ave",
				"12 108th st",
				"89 E. 42nd St."
			};
			
			// Simple query to demonstrate object creation in select clause.
			// Create Contact objects by using a constructor.
			var query1 = from i in Enumerable.Range ( 0, 5 )
				select new Contact ( names [ i ], addresses [ i ] );
			
			// List elements cannot be modified by client code.
			var list = query1.ToList ();
			foreach ( var contact in list )
			{
				Console.WriteLine ( "{0} {1}", contact.Name, contact.Address );
			}
			
			// Create Contact2 objects by using a static factory method.
			var query2 = from i in Enumerable.Range ( 0, 5 )
				select Contact2.CreateContact ( names [ i ], addresses [ i ] );
			
			// Console output is identical to query1.
			var list2 = query2.ToList ();
			
			// Keep the console open in debug mode.
			Console.WriteLine ( "Press any key to exit." );
			Console.ReadKey ();
		}
	}
}