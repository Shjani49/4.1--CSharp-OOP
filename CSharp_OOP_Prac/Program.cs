using System;

namespace CSharp_OOP_Prac
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputOne = null, inputTwo = null, inputThree = "Yes";

            // Null coalescing operator will use the left hand side if it is not null, otherwise the right side.
            Console.WriteLine(inputOne ?? "The value was null.");

            // It's kind of the same as:
            Console.WriteLine(inputOne != null ? inputOne : "The value was null.");


            // The can be strung together as well:
            Console.WriteLine(inputOne ?? inputTwo ?? inputThree);


        }
    }
}
