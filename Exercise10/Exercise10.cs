
using System;
using Exercise04;


namespace Exercise10
{
    class Exercise10 
    {
        static void Main(string[] args)
        {

            Console.Write("Press 1 , 2 or 3! ");
            var choice = int.Parse(Console.ReadLine());

            switch (choice)
            {

                case 1:

                    while (true)
                    {
                        double sum = 0;

                        Console.Write("Please input a number: ");
                        var a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Please inaput a second number: ");
                        var b = Convert.ToDouble(Console.ReadLine());

                        if (b == 0)
                        {
                            Console.WriteLine("Invalid number! Please input another.");
                        }
                        else
                        {
                            sum = a / b;
                            Console.WriteLine(sum);
                            break;
                        }
                    }
                    break;

                case 2:

                    Console.WriteLine(Exercise04.Exercise04.Replace());

                    break;

                case 3:

                    var color = "Black";


                    while (true)
                    {
                        Console.Write("Please choose a backgroundcolor:\n" +
                                "Black? Press 1.\n" +
                                "Blue? Press 2.\n" +
                                "Quit? Press 0.\n");
                        var choiceA = int.Parse(Console.ReadLine());

                        if (choiceA == 2)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            color = "Blue";
                        }
                        else if (choiceA == 1)
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            color = "Black";
                        }
                        else
                        {
                            break;
                        }
                    }
                    break;

                default:
                    {
                        Console.WriteLine("Bye, Bye");
                        break;
                    }
            }
        }
    }
}
