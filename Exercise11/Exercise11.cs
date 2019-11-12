using System;

namespace Exercise11
{
    class Exercise11
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please input a number: ");
                var number = int.Parse(Console.ReadLine());

                if (number > 0)
                {
                    for (int i = 0; i <= number; i++)
                    {
                        if (i == 0)
                        {
                            Console.WriteLine("0");
                        }
                        else if (i % 2 == 0)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine(i);
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.WriteLine(i);
                        }
                    }

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine();

                    for (int j = number;  j >= 0;  j--)
                    {
                        if (j == 0)
                        {
                            Console.WriteLine("0");
                        }
                        else if (j % 2 == 0)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine(j);
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.WriteLine(j);
                        }
                    }

                    Console.BackgroundColor = ConsoleColor.Black;

                    //Console.WriteLine(number);
                    break;
                }
                else
                {
                    Console.WriteLine("Not a valid number!");
                }
                //Console.WriteLine("Hello World!");
            }
        }
    }
}
