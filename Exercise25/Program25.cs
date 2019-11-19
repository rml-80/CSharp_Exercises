//Complete

using System;

namespace Exercise25
{
    class Program25
    {
        static int GetNumber()
        {
            int n = 0;
            while (true)
            {
                try
                {
                    Console.Write("input an Integer: ");
                    n = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Not a valid integer. Please try again.");
                }
            }
            return n;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    var x = GetNumber();
                    var y = GetNumber();

                    var div = x / y;

                    Console.WriteLine(div);
                    break;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Can't divide by zero. Please try again.");
                }
            }
        }
    }
}
