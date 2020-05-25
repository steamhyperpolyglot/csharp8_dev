using System;
using System.Collections.Generic;

namespace LocalFuncException
{
	class Program
	{
		static void Main ( string [] args )
		{
			IEnumerable<int> ienum = OddSequence(50, 110);
			Console.WriteLine("Retrieved enumerator...");

			foreach(var i in ienum) {
				Console.Write($"{i}");
			}
		}

		public static IEnumerable<int> OddSequence(int start, int end) {
			if (start < 0 || start > 99)
				throw new ArgumentOutOfRangeException("start must be between 0 and 99.");
			if (end > 100)
				throw new ArgumentOutOfRangeException("end must be less than or equal to 100.");
			if (start >= end)
				throw new ArgumentException("start must be less than end.");
			
			for (int i = start; i <= end; i++) {
				if (i % 2 == 1)
					yield return i;
			}
		}
	}
}