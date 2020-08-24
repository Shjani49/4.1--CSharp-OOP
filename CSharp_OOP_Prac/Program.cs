using System;

namespace CSharp_OOP_Prac
{
    class Program
    {
        static void Main(string[] args)
        {

            // If an input string contains a space, output "Multiple words.", otherwise output "One word."
            // Make sure the input is trimmed before checking. Try to do it with one variable for input and one with output.
            // Use a ternary operator. If you finish that early, Try to do it without any variables at all (remove the line above 
            // these comments).

            string input, output;
            Console.WriteLine("Please Eneter a String: ");
            input = Console.ReadLine();

            output = input.Trim().Contains(" ") ? "Multiple Words" : "One word";
            Console.WriteLine(output);

        }
    }
}
