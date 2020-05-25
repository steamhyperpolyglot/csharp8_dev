using System;

namespace ImplicitConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 42;
            double di = i;
            Console.WriteLine ( i / 5 );
            Console.WriteLine ( di / 5 );
            Console.WriteLine ( i / 5.0 );
        }
    }
}
