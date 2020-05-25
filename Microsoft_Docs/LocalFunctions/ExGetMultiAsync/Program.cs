using System;
using System.Threading.Tasks;

namespace ExGetMultiAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = GetMultipleAsync(6).Result;
            Console.WriteLine($"The returned value is {result:N0}");
        }

        static async Task<int> GetMultipleAsync(int secondsDelay) {
            Console.WriteLine("Executing GetMultipleAsync...");
            if (secondsDelay < 0 || secondsDelay > 5)
                throw new ArgumentOutOfRangeException("secondsDelay cannot exceed 5.");

            await Task.Delay(secondsDelay * 1000);
            return secondsDelay * new Random().Next(2, 10);
        }
    }
}
