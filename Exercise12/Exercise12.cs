//Complete

using System;

namespace Exercise12
{
    class Exercise12
    {
        static void Main(string[] args)
        {
            var x = 1;
            var y = 10;
            var z = 1;

            for (int i = x; i <= y; i++)
            {
                for (int j = z; j <= y; j++)
                {
                    Console.Write(x * z + "\t");
                    z++;
                }

                Console.WriteLine();
                x++;
                z = 1;
            }
        }
    }
}
