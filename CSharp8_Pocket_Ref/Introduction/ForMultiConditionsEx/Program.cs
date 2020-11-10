using System;

namespace ForMultiConditionsEx
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0, prevFib = 1, curFib = 1; i < 10; i++) {
                Console.WriteLine(prevFib);
                int newFib = prevFib + curFib;
                prevFib = curFib;
                curFib = newFib;
            }
        }
    }
}
