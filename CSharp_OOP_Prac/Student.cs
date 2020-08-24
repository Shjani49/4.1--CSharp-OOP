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

        // We have to specify the backing variable for EnergyLevel because we are doing some validation with the value. 
        private int _energyLevel;
        private int EnergyLevel
        {
            get
            {
                return _energyLevel;
            }
            set
            {
                // If the incoming value is over 100, clamp it to 100.
                if (value > 100)
                {
                    _energyLevel = 100;
                }
                else
                {
                    _energyLevel = value;
                }
            }
        }


        public Student()
        {
            DateOfBirth = DateTime.Now;
            EnergyLevel = 100;
            DoHomeWork();
            Sleep();
            Sleep();
            DoHomeWork();
            DoHomeWork();
            Sleep(5);
            PlayGames();

        }
       
        public void DoHomeWork()
        {
            EnergyLevel -= 25;
            Console.WriteLine(EnergyLevel);
        }
        public void Sleep()
        {
            EnergyLevel = 100; ;
            Console.WriteLine(EnergyLevel);
        }
        public void Sleep(int hours)
        {
            EnergyLevel += hours * 10;
            Console.WriteLine(EnergyLevel);
        }
        public void PlayGames()
        {
            EnergyLevel -= 15;
            Console.WriteLine(EnergyLevel);
        }

    }

}
