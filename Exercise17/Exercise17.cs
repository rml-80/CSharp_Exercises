//Completed

using System;

namespace Exercise17
{
    class Exercise17
    {

        static string ReverseStr(String txt)
        {
            char[] charArray = txt.ToCharArray();

            Array.Reverse(charArray);

            String newStr = String.Concat(charArray);

            return newStr;
        }

        static string SpaceRemove(String myTxt)
        {
            string noSpace = myTxt.Replace(" ", "");

            return noSpace;          
        }


        static void Main(string[] args)
        {
            Console.WriteLine("What word do you want to check? ");
            var myTxt = Console.ReadLine();
            var myText = SpaceRemove(myTxt);

            if (myText == ReverseStr(SpaceRemove(myText)))
            {
                Console.WriteLine($"{myTxt} is a palindrome");
            }
            else
            {
                Console.WriteLine($"{myTxt} is not a palindrome.");
            }
        
        }
    }
}
