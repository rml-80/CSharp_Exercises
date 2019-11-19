//Complete

using System;

namespace Exercise07
{
    class Exercise07
    {
        static void Main(string[] args)
        {
            Console.Write("Input the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The area of the circle is: " + area(radius));
            Console.WriteLine("The volume of the circle is: " + volume(radius));
        }

        static double area(double x)
        {
            double a = (x * x) * Math.PI;

            return a;
        }

        static double volume(double x) 
        {
            double a = (4 * Math.PI * (x * x * x)) / 3;

            return a;
        }
    }
}
