using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_OOP_Prac
{
    class Teacher
    {
        public int StaffID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private DateTime DateOfBirth { get; set; }

        public List<SchoolClass> ClassesTaught { get; set; }


        public static void Test()
        {
            Console.WriteLine("Teachers are responsible for instructing students in classes.");
        }

        public Teacher()
        {
            StaffID = 1000;
            FirstName = "John";
            LastName = "Doe";
            DateOfBirth = DateTime.Now;
            ClassesTaught = new List<SchoolClass>();
        }
    }
}
