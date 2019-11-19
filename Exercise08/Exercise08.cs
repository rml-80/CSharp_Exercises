//Complete

using System;

namespace Exercise08
{
    class Exercise08
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a decimal number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(square(number));
            Console.WriteLine(p2(number));
            Console.WriteLine(p10(number));
        }

        static double square(double x)
        {
            double y = Math.Sqrt(x);

            return y;
        }

        static double p2(double x)
        {
            double y = Math.Pow(x, 2);

            return y;
        }

        static double p10(double x) 
        {
            double y = Math.Pow(x, 10);

            return y;
        }
    }
}
