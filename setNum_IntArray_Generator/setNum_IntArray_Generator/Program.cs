using System;

namespace setNum_IntArray_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int solution;

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the positive integer you would like to be the solution.");
                    solution = Int32.Parse(Console.ReadLine());

                    if (solution < 1)
                    {
                        throw new Exception();
                    }

                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a positive integer!");
                }
            }


            // Lets the user know, that all of the numbers have been generated.
            Console.WriteLine("The list of numbers has been created.\nPress any button to close the console window.");
            Console.ReadKey();
        }
    }
}
