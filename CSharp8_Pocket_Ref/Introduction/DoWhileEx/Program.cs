using System;

namespace DoWhileEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            do {
                Console.WriteLine(i++);
            } while (i < 3);
        }
    }
}
