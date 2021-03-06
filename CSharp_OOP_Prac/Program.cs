﻿using System;
using System.Threading.Tasks;
using System.Collections.Generic;

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

            /* Group Task:
             
            Add an inaccessible stress level variable, initialized at 0. *
	            -When homework is done, increase stress by 30. *
	            -When sleep is done, decrease stress by 50 (or 5 per hour). *
	            -When games are done, decrease stress by 25. *
	            -Add a floor to stress level of 0 (similar to ceiling on energy). *
            Add a query method for stress level and that will output a string based on its level.
            Throw an exception if stress tries to go over 100. *
            If you finish: generate a student in main (you can clear out the stuff below this comment), and simulate 10 days for them. IE do homework and games until they're out of energy, sleep and repeat. I know it's a rather simple existence, but it'll suffice for now.
            */


            //  26/8/2020
            /*
          Practice Task:
         Add a "Pending Homework" property that is a stack of homework objects. 
         The homework class will have a complexity property of 1-5. Please validate and clamp to 1 if less than 1, and 5 if greater than 5.
         Modify the DoHomework method so that it will take the top homework off the stack, and the number of characters being written will be the complexity times 100. Energy level will decrease by complexity times 10, and stress will increase by complexity times 5.
         */
            
            Student myStudent = new Student();
            myStudent.pendingHomeWork.Push(new HomeWork() { Complexity = 3 });
            Console.WriteLine(myStudent.pendingHomeWork);
            myStudent.DoHomework();
            Console.WriteLine(myStudent.pendingHomeWork);




            Student ourStudent = new Student("Joe", "Dirt");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"----------\nStarting Day {i}");
                try
                {
                    ourStudent.DoHomework();
                    ourStudent.DoHomework();
                    ourStudent.PlayGames();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                ourStudent.Sleep(7);
                Console.WriteLine($"Energy Level: {ourStudent.QueryEnergyLevel()}\nStress Level: {ourStudent.QueryStressLevel()}");
            }

            // 25-08-2020

            SchoolClass theClass = new SchoolClass();
            Teacher theTeacher = theClass.ClassTeacher;
            theTeacher.FirstName = "Jane";

            Console.WriteLine($"The class has the classcode {theClass.ClassCode}, is called {theClass.ClassName} and is being taught by {theClass.ClassTeacher.FirstName} {theClass.ClassTeacher.LastName}.");
           
            // Assigning properties with individual statements.
            SchoolClass historyClass = new SchoolClass();
            historyClass.ClassCode = "HIST101";
            historyClass.ClassName = "Introduction to History";

            // Rather than assigning props as multiple statements, you can assign them during construction using an initializer list.
            SchoolClass englishClass = new SchoolClass()
            {
                ClassCode = "ENGL101",
                ClassName = "Introduction to English"
            };
            // Using a constructor.
            SchoolClass programmingClass = new SchoolClass("CPRG101", "Introduction to Programming");


            Teacher sueTeacher = new Teacher()
            {
                StaffID = 2050,
                FirstName = "Sue",
                LastName = "Smith"
            };
            Teacher joeTeacher = new Teacher()
            {
                StaffID = 2050,
                FirstName = "Joe",
                LastName = "Testificate"
            };

            // For this test run:
            // Old teacher will be NULL
            // New teacher will be Sue
            // "this" will be History class
            historyClass.ClassTeacher = sueTeacher;

            // For this test run:
            // Old teacher will be Sue
            // New teacher will be Joe
            // "this" will be History class
            historyClass.ClassTeacher = joeTeacher;

            englishClass.ClassTeacher = joeTeacher;
            programmingClass.ClassTeacher = joeTeacher;

            Console.WriteLine($"The class has the classcode {historyClass.ClassCode}, is called {historyClass.ClassName} and is being taught by {historyClass.ClassTeacher.FirstName} {historyClass.ClassTeacher.LastName}.");

            StaticExample.EchoSomethingOut();


            Teacher.Test();


            Pen redPen = new Pen()
            {
                Brand = "Bic",
                InkColor = "Red",
                HasLid = true,
                MaxInk = 1
            };
            Pen bluePen = new Pen()
            {
                Brand = "Bic",
                InkColor = "Blue",
                HasLid = false,
                MaxInk = 10
            };
            Pen blackPen = new Pen()
            {
                Brand = "Pilot",
                InkColor = "Black",
                HasLid = false,
                MaxInk = 150
            };

            TestPen(redPen);
            TestPen(bluePen);
            TestPen(blackPen);
        }
        /* Borrowed from james code.*/
        public static void TestPen(Pen toTest)
        {
            //Console.WriteLine($"This is a {toTest.Brand} {toTest.InkColor} pen which has {toTest.InkLevel}% of its ink remaining.");
            Console.WriteLine(toTest);
            toTest.Write();
            // Console.WriteLine($"This is a {toTest.Brand} {toTest.InkColor} pen which has {toTest.InkLevel}% of its ink remaining.");
            Console.WriteLine(toTest);
            try
            {
                toTest.Write("Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing...Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // Console.WriteLine($"This is a {toTest.Brand} {toTest.InkColor} pen which has {toTest.InkLevel}% of its ink remaining.");
            Console.WriteLine(toTest);



        }
    }
}