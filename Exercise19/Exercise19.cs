//Complete

using System;

namespace Exercise19
{
    class Exercise19
    {
        static void Main(string[] args)
        {
            int[] coins = new int[] { 500, 200, 100, 50, 20, 10, 5, 2, 1 };

            Random rnd = new Random();
            int price = rnd.Next(500);
            var paid = 0;

            while (true)
            {
                Console.WriteLine("Price: " + price + " kr");
                Console.Write("Enter payment: ");
                paid = int.Parse(Console.ReadLine());

                if (price > paid)
                {
                    Console.WriteLine("Payment not enough! Pay more!");
                }
                else
                {
                    break;
                }
            }

            int change = paid - price;

            Console.WriteLine("To return to customer " + change + " kr");
            Console.WriteLine("----------------------------------");

            for (int i = 0; i < coins.Length; i++)
            {
                var times = change / coins[i];

                if (times > 0)
                {
                    Console.WriteLine(times + " x " + coins[i] + " kr");
                    var pay = coins[i] * times;
                    change -= pay;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Have a nice day!");
        }
    }
}
