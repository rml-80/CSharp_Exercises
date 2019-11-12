using System;

namespace Exercise06
{
    class Exercise06
    {
        static void Main(string[] args)
        {
            Console.Write("Input a Integer: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a second Integer: ");
            int second = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine(first);
            //Console.WriteLine(second);
            Console.WriteLine();
            Console.WriteLine("Smallest: " + Math.Min(first, second));
            Console.WriteLine("biggest: " + Math.Max(first, second));
            Console.WriteLine();
            Console.WriteLine("Sum: " + sum(first, second));
            Console.WriteLine("Difference: " + sub(first, second));
            Console.WriteLine();
            Console.WriteLine("Multiplied: " + multi(first, second));
            Console.WriteLine("Divided: " + div(first, second));

        }

        static int sum(int x, int y)
        {
            return x + y;
        }

        static int sub(int x, int y)
        {
            int a = Math.Max(x, y);
            int b = Math.Min(x, y);

            return a - b;
        }

        static int multi(int x,int y)
        {
            return x * y;
        }

        static float div(float x, float y)
        {
            float a = Math.Max(x, y);
            float b = Math.Min(x, y);

            return a / b;
        }
    }
}
