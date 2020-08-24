using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_OOP_Prac
{
    public class Student
    { // Public properities can be set externally.
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Private properities can only be set in this class.
        private DateTime DateOfBirth { get; set; }

        public Student()
        {
            DateOfBirth = DateTime.Now;
        }

        public void DoHomeWork()
        {

        }

    }
}
