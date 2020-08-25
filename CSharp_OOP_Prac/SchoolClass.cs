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

        public Teacher ClassTeacher { get; set; }
        public SchoolClass()
        {
            ClassCode = "CLASS101";
            ClassName = "Science Class";
            MaxStudents = 50;
            ClassTeacher = new Teacher();

        }
    }
}
