using System;

namespace CSharp_OOP_Prac
{
    class Program
    {
        static void Main(string[] args)
        {

            Student myStudent = new Student();
            WriteSomeStuff();
            WriteSomeStuff();
            WriteSomeStuff("Yes!");
            WriteSomeStuff("No!");
            WriteSomeStuff("Maybe!");
            WriteSomeStuff("Yes", "No");
        }
        // Multiple versions of a method can be declared, as long as their parameter type lists differ.
        // This is called method "overloading".
        // The names of the parameters do not matter, they must be different types.
        static void WriteSomeStuff()
        {
            Console.WriteLine("Some stuff is being written!");
        }
        static void WriteSomeStuff(string stuff)
        {
            Console.WriteLine(stuff);
        }
        static void WriteSomeStuff(string someStuff, string someOtherStuff)
        {
            Console.WriteLine(someStuff + someOtherStuff);
        }
    }
}
