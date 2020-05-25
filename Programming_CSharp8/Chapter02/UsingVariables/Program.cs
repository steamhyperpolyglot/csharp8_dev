using System;

namespace UsingVariables
{
	class Program
	{
		static void Main ( string [] args )
		{
			string part1 = "the ultimate question";
			string part2 = "of something";
			int theAnswer = 42;

			part2 = "of life, the universe, and everything";

			string questionText = "What is the answer to " + part1 + ", " + part2 + "?";
			string answerText = "The answer to " + part1 + ", " + part2 + ", is: " + theAnswer;

			Console.WriteLine(questionText);
			Console.WriteLine(answerText);
		}
	}
}
