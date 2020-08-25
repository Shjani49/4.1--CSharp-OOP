using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_OOP_Prac
{
    class SchoolClass
    {
        public string ClassCode { get; set; }
        public string ClassName { get; set; }
        private int MaxStudents { get; set; }

        
        private Teacher _teacher;
        public Teacher ClassTeacher
        {
            get
            {
                return _teacher;
            }
            set
            {
                // _teacher is "Old teacher"
                // value is "New teacher"
                // this is the current class we're working with

                // Check if the current (old, before reassignment) teacher reference of this class object instance is null. If it's not, check if this class instance is in that teacher's class list. 
                // By having the null check as the left (first) operand of the 'and' (&&), we ensure that we don't get a null reference exception.
                // The second operand of a an 'and' will only be checked if the first operand is true. Since it's only true if the reference is not null, we're "safe".
                if (_teacher != null && _teacher.ClassesTaught.Contains(this))
                {
                    // If it is, remove it, as we're changing teachers.
                    // It should always be, assuming this class had a teacher before and nobody circumvented our properties (and we didn't make any mistakes).
                    _teacher.ClassesTaught.Remove(this);
                }
                // Add this class instance to the new teacher's class list.
                value.ClassesTaught.Add(this);
                // Actually assign the reference variable.
                _teacher = value;
            }
        }
        public SchoolClass()
        {
            ClassCode = "CLASS101";
            ClassName = "Science Class";
            MaxStudents = 50;
            //ClassTeacher = new Teacher();

        }
    }
}
