using System;
using System.Collections.Generic;

namespace ListsAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruit = new List<string>();

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter a fruit; ");
                fruit.Add(Console.ReadLine());
                

            }
            fruit.Add("pineapple");

            foreach (string fruitItem in fruit)
            {
                Console.WriteLine($"Fruit on the list: {fruitItem}");
            }

            int indexOfPineapple = fruit.IndexOf("pineapple");

            Console.WriteLine($"Pineapple is on index{indexOfPineapple}");

            fruit[indexOfPineapple] = "orange";

            foreach (string fruitItem in fruit)
            {
                Console.WriteLine($"Fruit on the Uptaded list: {fruitItem}");
            }

            fruit.RemoveAt(fruit.Count - 1);

            foreach (string fruitItem in fruit)
            {
                Console.WriteLine($"Trimmed fruit list: {fruitItem}");
            }

        }
    }
}
