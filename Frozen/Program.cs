using System;
using System.IO;

namespace Frozen
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayElementsFromArray(GetDataFromFile());
        }


        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach(string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }


        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\rvesk\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
}
