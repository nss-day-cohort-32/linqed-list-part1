using System;
using System.Collections.Generic;
using System.Linq;

namespace linqExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Restriction/Filtering Operations
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> LFruits = from fruit in fruits
                                        where fruit.StartsWith("L")
                                        select fruit;

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            IEnumerable<int> fourSixMultiples = numbers.Where(x => x % 4 == 0 || x % 6 == 0);

            //Ordering Operations
            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            List<string> descend = names.OrderByDescending(n => n).ToList();

            // Build a collection of these numbers sorted in ascending order (uses number list on line 20)
            List<int> ascNums = numbers.OrderBy(n => n).ToList();

            //Aggregate Operations
            // Output how many numbers are in this list (uses number list on line 20)
            var howManyNums = numbers.Count();

            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };

            var totalMoney = purchases.Sum();

            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };

            var mostExpensive = prices.Max();

            //Partitioning Operations

            //Store each number in the following List until a perfect square is detected.
            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };

            //one way to solve
            List<int> perfectSquare = wheresSquaredo.TakeWhile(num => Math.Sqrt(num) % 1 != 0).ToList();
            
            //another way to solve
            List<int> perfectSquare2 = wheresSquaredo.TakeWhile(num =>
            {
                int number = Convert.ToInt32(Math.Sqrt(num));
                return number * number != num;
            }).ToList();

        }
    }
}
