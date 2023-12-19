using System;
using System.Linq;

namespace ProjetLINQ
{
    internal class Program
    {
        public static Program p = new Program();
        static void Main(string[] args)
        {
            // Console.WriteLine("LINQ !");
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("------"); // Séparateur
            var pairNums =
                from num in numbers
                where num % 2 == 0 // que c'est un nombre Pair
                select num;

            foreach (int num in pairNums)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("------"); // Séparateur
            var bigNums =
                from num in numbers
                where num > 5
                select num;

            foreach (int num in bigNums)
            {
                Console.WriteLine(num);
            }


            Console.WriteLine("------!!!------"); // Gros Séparateur
            var pairNumsLambda = numbers.Where(nb => nb % 2 == 0);

            foreach (int num in pairNumsLambda)
            {
                Console.WriteLine(num);
            }


            Console.WriteLine("------"); // Séparateur
            var bigPairNumsLambda = numbers.Where(nb => nb % 2 == 0 && nb > 5);

            foreach (int num in bigPairNumsLambda)
            {
                Console.WriteLine(num);
            }
        }
    }
}
