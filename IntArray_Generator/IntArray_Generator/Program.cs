using System;
using System.IO;
using System.Text;

namespace IntArray_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            // This console application generates an array of integers and writes them to a file.
            // The length of that array can be set by the user after running the program.

            Console.WriteLine("Name your file. Please include the path infront of the name:");
            string path = @"" + Console.ReadLine();
            path = @"C:\Users\marci\Desktop\testfile.txt";
            int arrLength;

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




            try
            {
                if (File.Exists(path))
                {
                    throw new Exception();
                }

                File.Create(path);
            }
            catch (Exception)
            {
                Console.WriteLine("This file already exists");
            }


            Console.ReadKey();
        }
    }
}
