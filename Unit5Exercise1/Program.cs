using System;
using System.Numerics;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Draw a rectangle");
            Console.WriteLine("2. Draw a square triangle");
            Console.WriteLine("3. Draw an isosceles triangle");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            Int32.TryParse(Console.ReadLine(), out int choice);

            // Keep asking until choosing Exit
            while (choice != 4)
            {
                switch (choice)
                {
                    case 1:
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 15; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j <= i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 4 - i; j++)
                            {
                                Console.Write(" ");
                            }
                            for (int k = 0; k < i * 2 + 1; k++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    default:
                        Console.WriteLine("The choice is invalid!");
                        break;
                }

                Console.Write("You may choose again: ");
                Int32.TryParse(Console.ReadLine(), out choice);
            }

            Environment.Exit(0);
        }
    }
}