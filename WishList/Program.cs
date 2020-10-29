using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WishList
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Roland Strod\Data\WishList.txt";
            List<string> dataFromFile = File.ReadAllLines(filePath).ToList();

            foreach(string line in dataFromFile)
            {
                Console.WriteLine($"Data from file: {line}");
            }

            dataFromFile.Add("Minecraft");
            File.WriteAllLines(filePath, dataFromFile);

        }
    }
}
