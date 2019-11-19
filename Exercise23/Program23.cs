//Complete

using System;
using System.Linq;

namespace Exercise23
{
    class Program23
    {
        
        static void Main(string[] args)
        {
            int[] numbers = new int[7];

            for (int i = 0; i < numbers.Length; i++)
            {
                Random rnd = new Random();
                var number = rnd.Next(1, 40);   //generate random number between 1 - 40
                
                //check that the number isn't in the array
                if (!numbers.Contains(number))  
                {
                    // if not in the array. Add it
                    numbers[i] = number;
                }
                // check if the number is in the array.
                else if (numbers.Contains(number))
                {
                    // if it is. subtract 1 from variable i. so that there will be seven i total.
                    i--;
                }
                
            }
            Array.ForEach(numbers, Console.WriteLine);
        }
    }
}
