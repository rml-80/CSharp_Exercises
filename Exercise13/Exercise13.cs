//Complete

using System;

namespace Exercise13
{
    class Exercise13
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var newRnd = rnd.Next(1, 500);
            var low = 1;
            var high = 500;


            while (true)
            {
                Console.Write($"Guess a number between {low} - {high}: ");
                var guess = int.Parse(Console.ReadLine());

                if (guess == newRnd)
                {
                    Console.WriteLine($"You guest number {guess}. That is correct!");
                    break;
                }
                else if (guess < newRnd)
                {
                    Console.WriteLine($"You guest number {guess}. That was too low.");
                    if (guess > low)
                    {
                        low = guess + 1;
                    }
                }
                else
                {
                    Console.WriteLine($"You guest number {guess}. that was too high");

                    if (guess < high)
                    {
                        high = guess - 1;
                    }
                }
            }
        }
    }
}
