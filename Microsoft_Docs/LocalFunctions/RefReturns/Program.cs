using System;

namespace RefReturns
{
    class NumberStore
    {
        private int [] numbers = { 1, 3, 7, 15, 31, 63, 127, 255, 511, 1023 };

        public ref int FindNumber ( int target )
        {
            for ( int ctr = 0; ctr < numbers.Length; ctr++ )
            {
                if ( numbers [ ctr ] >= target )
                    return ref numbers [ ctr ];
            }

            return ref numbers [ 0 ];
        }

        public override string ToString() => string.Join ( " ", numbers );
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var store = new NumberStore ();
            Console.WriteLine ( $"Original sequence: {store.ToString ()}" );
            int number = 16;
            ref var value = ref store.FindNumber ( number );
            value *= 2;
            Console.WriteLine ( $"New sequence:     {store.ToString()}" );
        }
    }
}
