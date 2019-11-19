// completed

using System;

namespace Exercise15
{
    class Exercise15
    {
        static void Main(string[] args)
        {
            //Console.Write("Please input a number: ");
            //var num = int.Parse(Console.ReadLine());

            //for (int i = num - 1; i > 0; i--)
            //{
            //    if (num % i == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            var sum = 0;
            var x = 1;
            var greger = 0;

            while (greger < 3)
            {
                sum = 0;
                for (int i = 1; i < x; i++)
                {
                    if (x % i == 0)
                    {
                        sum += i;
                    }
                }

                if (x == sum)
                {
                    Console.WriteLine(sum);
                    greger++;
                }

                x++;

            }
        }
    }
}