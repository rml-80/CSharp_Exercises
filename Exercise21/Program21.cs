//Complete

using System;
using System.Collections;

namespace Exercise21
{
    class Program21
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a string with numbers separeted with comma: ");
            Console.WriteLine("Example: 1,2,3,55,99");
            var str = Console.ReadLine();
            Console.WriteLine();

            string[] txt = str.Split(',');

            int[] num = Array.ConvertAll(txt, int.Parse);

            var min = num[0];
            var max = num[0];
            var sum = 0;
            var average = 0;

            for (int i = 0; i < num.Length; i++)
            {
                if (min > num[i])
                    min = num[i];
                if (max < num[i])
                    max = num[i];
            }

            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }

            average = sum / num.Length;

            Console.WriteLine("========================================");
            Console.WriteLine("The highest number in the array is: " + max);
            Console.WriteLine("The lowest number in the array is: " + min);
            Console.WriteLine("The average of the array is " + average);
        }
    }
}
