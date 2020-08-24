using System;

namespace CSharp_OOP_Prac
{
    class Program
    {
        static void Main(string[] args)
        {
            // Modify the student class to have a property for energy level.
            // The energy level should not be accessible from outside the student.
            // Create methods in the student that are accessible, for do homework and sleep.
            // Do homework will lower the student's energy level by 25. Sleep will set the energy level to 100.
            // When a student is created, ensure their energy level starts at 100.

            // Overload the sleep method to allow a value of hours. Increase energy by 10 per hour slept.
            // Add a ceiling of 100 to sleep.

            // Task:
            // Add a play games method that will decrease energy by 15.

            Student myStudent = new Student();
            myStudent.FirstName = "Jane";

            Console.WriteLine(myStudent.StudentID + ": " + myStudent.FirstName + " " + myStudent.LastName);

        }
        
    }
}
