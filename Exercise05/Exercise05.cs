//Complete

using System;

namespace Exercise05
{
    class Exercise05
    {
        static void Main(string[] args)
        {
            //String [1,2,3,4,5]
            //Desired output [1,4,5,6,7,8,9,10]

            var oTxt = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";

            var txt = oTxt.Substring(oTxt.IndexOf("["), oTxt.Length - oTxt.IndexOf("["));

            Console.WriteLine(oTxt);

            var noNumber = oTxt.Remove(oTxt.IndexOf(":") + 1);
            txt = txt.Remove(txt.IndexOf("2"), txt.IndexOf("3") - 1);

            for (int i = 6; i < 11; i++)
            { 
                txt = txt.Insert((txt.Length - 1), $",{i}");
            }

            Console.WriteLine(noNumber + " " + txt);
        }
    }
}
