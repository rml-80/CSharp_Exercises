//Complete

using System;
using System.Collections;

namespace Exercise20
{
    class Program20
    {
        static void Main(string[] args)
        {
            int[] arrA = new int[10];
            ArrayList even = new ArrayList();
            ArrayList odd = new ArrayList();

            for (int i = 0; i < arrA.Length; i++)
            {
                Random rnd = new Random();
                var number = rnd.Next(1, 1000);
                arrA[i] = number;
            }
            
            foreach (var item in arrA)
            {
                Console.Write(item + "\t");
            }

            for (int i = 0; i < arrA.Length; i++)
            {
                //Check if even
                var number = arrA[i];

                if (number % 2 == 0)
                {
                    even.Add(arrA[i]);
                }
                else
                {
                    odd.Add(arrA[i]);
                }
            }

            Console.WriteLine("\n");

            int[] evenArr = even.ToArray(typeof(int)) as int[];
            int[] oddArr = odd.ToArray(typeof(int)) as int[];

            var slots = evenArr.Length + oddArr.Length;

            int[] sorted = new int[slots];

            oddArr.CopyTo(sorted, 0);
            evenArr.CopyTo(sorted, oddArr.Length);

            foreach (var item in sorted)
            {
                Console.Write(item + "\t");
            }

        }
    }
}
