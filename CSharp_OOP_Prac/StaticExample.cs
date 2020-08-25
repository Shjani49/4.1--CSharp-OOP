using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_OOP_Prac
{
    // If something is 'static' then there is one copy of it held in memory.
    // It does not need to be instantiated to be used, and the properties / methods are called on the type itself.
    // An example of this is the Math class (Math.Sqrt(), Math.Max(), etc).
    static class StaticExample
    {
        static public void EchoSomethingOut()
        {
            Console.WriteLine("Test 1, 2, 3");
            Console.WriteLine("Stuff has been written.");
        }
    }
}
