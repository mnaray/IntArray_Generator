using System;
using System.IO;

namespace setNum_IntArray_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name your file. Please include the full path infront of the name:");
            string path = @"" + Console.ReadLine();
            // path = @"C:\Users\marci\Desktop\testfile.txt";

            int solution;
            int arrLength;

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

            // The amount of integers to generate is set here with a user input
            // It will only work if the input is an integer, otherwise it will ask for a number again.
            Console.WriteLine("Please enter the amount of integers to generate:");
            while (true)
            {
                try
                {
                    arrLength = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("The number you entered can not be used as the amount of numbers to generate.\nPlease enter an integer above the value of zero.");
                }
            }

            // This section of the script adds the numbers to the file.
            try
            {
                // Checks if the file exists
                // If so, then the process will stop
                if (File.Exists(path))
                {
                    throw new Exception();
                }

                // Simply tells the user, that there's something happening
                Console.WriteLine("Loading . . .");

                // for-loop that writes randomly generated numbers to the file
                for (int i = 0; i < arrLength - solution; i++)
                {
                    int rand_num = 0;
                    while (rand_num == solution)
                    {
                        Random rd = new Random();
                        rand_num = rd.Next(-10000000, 10000000);
                    }
                    File.AppendAllText(path, rand_num.ToString() + Environment.NewLine);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("This file already exists");
            }


            // Lets the user know, that all of the numbers have been generated.
            Console.WriteLine("The list of numbers has been created.\nPress any button to close the console window.");
            Console.ReadKey();
        }
    }
}
