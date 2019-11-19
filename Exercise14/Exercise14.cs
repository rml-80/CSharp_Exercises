//Complete

using System;

namespace Exercise14
{
    class Exercise14
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double times = 0;
            while (true)
            {
                Console.Write("Please input a number: ");
                var n = double.Parse(Console.ReadLine());

                if (n != -1)
                {
                    sum += n;
                    times++;
                }
                else
                {
                    double average = sum / times;
                    Console.WriteLine($"The sum of the enterd number are {sum}.");
                    Console.WriteLine($"The average is {average}.");
                    break;
                }
            }
        }
    }
}
