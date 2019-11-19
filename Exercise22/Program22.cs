//Complete

using System;

namespace Exercise22
{
    class Program22
    {
        static void Main(string[] args)
        {
            string[] badWords = new string[] { "fuck", "hell", "hoe", "dick", "asshole" };

            Console.WriteLine("Enter a string: ");
            var txt = Console.ReadLine();

            foreach (var item in badWords)
            {
                txt = txt.Replace(item, "*flowers*");
            }

            Console.WriteLine(txt);
            
        }
    }
}
