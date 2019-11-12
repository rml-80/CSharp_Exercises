using System;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input string: The quick fox Jumped Over the DOG
            // Wanted output: The brown fox jumped over the lazy dog

            string input = "The quick fox Jumped Over the DOG";

            var txt = input.Replace("quick", "brown")
                            .Replace("Jumped", "jumped")
                            .Replace("DOG", "dog")
                            .Replace("Over", "over");
            txt = txt.Insert(txt.IndexOf("dog") - 1, " lazy");
            Console.WriteLine(txt);
        }
    }
}
