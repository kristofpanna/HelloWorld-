using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello();

            bool goodDog = true;
            Console.WriteLine("It's {0}, my favorite number is {1}. And yours? ", goodDog, 42.0);

            int yourFavorite;
            int.TryParse(Console.ReadLine(), out yourFavorite);
            Console.WriteLine("Your favorite is {0}.", yourFavorite);

            int alma = 1;
            alma += 3 + 4 + 5;
            alma++;
            Console.WriteLine(alma);

        }

        private static void SayHello()
        {
            Console.WriteLine("Hello PrefixBox!");
        }
    }
}
