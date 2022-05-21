using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PickRandomFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\...\samples";

            string randomFood, randomDrink, randomMovie;
            randomFood = GetRandomFromFile("foods.txt", filePath);
            randomDrink = GetRandomFromFile("drinks.txt", filePath);
            randomMovie = GetRandomFromFile("movies.txt", filePath);

            Console.WriteLine($"Tonight you will have some {randomFood} with {randomDrink} and watch {randomMovie}");
            Console.ReadLine();
        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random r = new Random();
            int randomIndex = r.Next(0, someArray.Length);
            return randomIndex;
        }

        private static string GetRandomFromFile(string filename, string filePath)
        {
            filePath += @"\" + filename;
            string[] dataFromFile = File.ReadAllLines(filePath);
            string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)];

            return randomElement;
        }
    }
}
