using System;

namespace ObjectInstancesEx
{
	internal class Program
	{
		public static void Main ( string [] args )
		{
			Panda p1 = new Panda("Pan Dee");
			Panda p2 = new Panda ("Pan Dah");

			Console.WriteLine (p1.Name);
			Console.WriteLine ( p2.Name );

			Console.WriteLine ( Panda.Population );
		}
	}
}