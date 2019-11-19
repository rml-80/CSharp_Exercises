//Completed

using System;

namespace Exercise04
{
    public class Exercise04
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

            string t = input.ToLower();
            t = char.ToUpper(t[0]) + t.Substring(1);
            t = t.Replace("quick", "brown")
            //                .Replace("Jumped", "jumped")
            //                .Replace("DOG", "dog")
            //                .Replace("Over", "over");
            t = t.Insert(t.IndexOf("dog") - 1, " lazy");


            return t;
        }
    } 
}
