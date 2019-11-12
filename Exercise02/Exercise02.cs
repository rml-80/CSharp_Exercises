using System;

namespace Exercise02
{
    class Exercise02
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            DateTime yesterday = getYesterday();
            DateTime tomorrow = getTomorrow();

            Console.WriteLine("Yesterdays date was " + yesterday);
            Console.WriteLine("Todays date is " + today);
            Console.WriteLine("Tomorrows date is " + tomorrow);
        }

        static DateTime getYesterday()
        { 
            return DateTime.Now.AddDays(-1);
        }

        static DateTime getTomorrow()
        {
            return DateTime.Now.AddDays(1);
        }
            
    }
}
