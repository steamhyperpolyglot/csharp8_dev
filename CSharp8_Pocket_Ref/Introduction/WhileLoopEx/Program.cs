using System;

namespace WhileLoopEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i < 3) {         // Braces here are optional
                Console.Write(i++);
            }
        }
    }
}
