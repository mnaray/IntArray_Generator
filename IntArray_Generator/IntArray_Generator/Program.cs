using System;
using System.IO;

// This console application generates an array of integers and writes them to a file.
// The length of that array can be set by the user after running the program.


namespace IntArray_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            // These lines takea file path and name as Input, to then create a file
            // There's also an empty integer variable, that is going to be the amount of numbers to generate.
            Console.WriteLine("Name your file. Please include the path infront of the name:");
            string path = @"" + Console.ReadLine();
            // path = @"C:\Users\marci\Desktop\testfile.txt";
            int arrLength;


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
                for (int i = 0; i < arrLength; i++)
                {
                    Random rd = new Random();
                    int rand_num = rd.Next(-10000000, 10000000);
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
