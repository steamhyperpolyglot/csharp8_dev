using System;
using System.Linq;

namespace SimpleLinqLambda
{ 
	class Program
	{
		public static void Main ( string [] args )
		{
			// Data source.
			int [] scores = { 90, 71, 82, 93, 75, 82 };
			
			// The call to Count forces iteration of the source.
			int highScoreCount = scores.Count ( n => n > 80 );

			Console.WriteLine ( "{0} scores are greater than 80", highScoreCount );
		}
	}
}