//Complete

using System;

namespace Exercise16
{
    class Exercise16
    {
        static int Fibonacci(int n)
        {
            int a = 0, b = 1, result = 0;

            for (int i = 0; i < n; i++)
            {
                result = a;
                a = b;
                b = result + b;
            }
            return a;
        }

        static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}", Fibonacci(i));
            }

        }
    }
}
