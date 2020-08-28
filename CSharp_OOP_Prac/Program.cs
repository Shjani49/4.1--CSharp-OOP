using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_OOP_Prac
{
    class Program
    {
        static void Main(string[] args)
        {
            // LINQ stands for Language INtegrated Query.
            // It allows us to run "SQL" queries on data structures in C#.

            List<int> testList = new List<int>() { 2, 5, 12, 7, 32, 95, 42, 65, 9, 42, 7, 42 };

            // We've looked at a couple in passing so far, mostly the aggregate ones.

            // .Max() and .Min() are sort of the equivalent of MAX() and MIN() in SQL.
            Console.WriteLine($"The largest number is {testList.Max()} and the smallest number is {testList.Min()}.");

            // .Average() is sort of equivalent to AVG() in SQL.
            Console.WriteLine($"The average number is {testList.Average()}.");

            // .Sum() is sort of equivalent to SUM() in SQL.
            Console.WriteLine($"The sum is {testList.Sum()}.");

            // .All() will return a boolean which will indicate whether all of the items satisfy a condition (lambda).
            Console.WriteLine($"All numbers are greater than 1: {testList.All(x => x > 1)}.");
            Console.WriteLine($"All numbers are greater than 50: {testList.All(x => x > 50)}.");

            // .Any() will return a boolean which will indicate whether any of the items satisfy a condition (lambda).
            Console.WriteLine($"Any number is less than 1: {testList.Any(x => x < 1)}.");
            Console.WriteLine($"Any number is greater than 50: {testList.Any(x => x > 50)}.");

            // .Count() will return a number of the items that satisfy a condition (lambda).
            Console.WriteLine($"Number of items: {testList.Count()}.");
            Console.WriteLine($"Number of items greater than 20: {testList.Count(x => x > 20)}.");
            Console.WriteLine($"Number of items less than 50: {testList.Count(x => x < 50)}.");

            // .Distinct() will return the unique items, no duplicates. It typically preserves the first occurance in terms of order. Other methods can be chained thereafter to operate on the distinct items.
            Console.WriteLine($"Number of distinct items: {testList.Distinct().Count()}.");
            Console.WriteLine($"Number of distinct items greater than 20: {testList.Distinct().Count(x => x > 20)}.");
            Console.WriteLine($"Number of distinct items less than 50: {testList.Distinct().Count(x => x < 50)}.");

            // .OrderBy() will reorder the list based on the lambda comparison provided.
            Console.Write("List in order: ");
            foreach (int item in testList.OrderBy(x => x))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.Write("Distinct list in order: ");
            foreach (int item in testList.Distinct().OrderBy(x => x))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // .Select() will return a sub-list of associated values based on the lambda.
            Console.Write("List in order, plus 1: ");
            foreach (int item in testList.Select(x => x + 1).OrderBy(x => x))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // .Where() will return a sub-list of filtered values based on the lambda.
            Console.Write("List in order, only over 50: ");
            foreach (int item in testList.Where(x => x > 50).OrderBy(x => x))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.Write("List in order, only evens: ");
            foreach (int item in testList.Where(x => x % 2 == 0).OrderBy(x => x))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // average, distinct, where, select
            // Find the average of the distinct values over 25, but subtract 5 from each before the average takes place.
            Console.WriteLine($"Answer: {testList.Where(x => x > 25).Distinct().Select(x => x - 5).Average()}");





        }
    }
}