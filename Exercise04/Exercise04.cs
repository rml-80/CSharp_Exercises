using System;

namespace Exercise04
{
    class Exercise04
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Replace());
        }
            //Input string: The quick fox Jumped Over the DOG
            // Wanted output: The brown fox jumped over the lazy dog
            public static string Replace()
            {
                string input = "The quick fox Jumped Over the DOG";

                var txt = input.Replace("quick", "brown")
                                .Replace("Jumped", "jumped")
                                .Replace("DOG", "dog")
                                .Replace("Over", "over");
                txt = txt.Insert(txt.IndexOf("dog") - 1, " lazy");

                return txt;
            }
        
    }
}
