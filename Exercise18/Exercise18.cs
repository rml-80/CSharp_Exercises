//Complete

using System;

namespace Exercise18
{
    class Exercise18
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                Random rnd = new Random();
                var number = rnd.Next(10, 100);
                arr[i] = number;
            }

            double[] dArr = new double[10];

            for (int i = 0; i < dArr.Length; i++)
            {
                var a = Convert.ToDouble(arr[i]);
                var b = i + 1;

                    var div = a / b;
                    dArr[i] = div;
            }

            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Array.ForEach(dArr, Console.WriteLine);
        }
    }
}
