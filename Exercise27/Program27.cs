//Complete

using System;
using System.IO;

namespace Exercise27
{
    class Program27
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("TextFile1.txt"))
            {
                Console.WriteLine(reader.ReadToEnd());
            }  
        }
    }
}
