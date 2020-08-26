using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_OOP_Prac
{
    public class Pen
    {
        public string Brand { get; set; }
        public string InkColor { get; set; }
        public int MaxInk { get; set; }
        public bool HasLid { get; set; }

        private double _inkLevel;
        public double InkLevel
        {
            get
            {
                //return round by 5%
                return Math.Round(_inkLevel / 5.0) * 5;
            }
            private set
            {
                // If the incoming value is over 100, set it to 100
                if (value > 100)
                {
                    _inkLevel = 100;
                }
                else
                {
                    if (value < 0)
                    {
                        throw new Exception("Can't write anything! We are out of Ink.");
                    }
                    _inkLevel = value;
                }
            }
        }
        public Pen()
        {
            Brand = "Bic";
            InkColor = "Red";
            HasLid = true;
            MaxInk = 250;
            InkLevel = 100;
        }
        public void Write()
        {
            string myString = "HelloWorld";
            double length = myString.Length;
            double Percentage = (0.05 / MaxInk) * 100;
            InkLevel = _inkLevel - (Percentage * length);


        }
        public void Write(string characterCount)
        {
            string myString1 = characterCount;
            double LengthOfmyString1 = myString1.Length;
            double Percentage = (0.05 / MaxInk) * 100;
            //From  Games Code...
            // Before: 
            // InkLevel -= percentagePerCharacter * characterCount
            // This is a problem because it calls the getter, behind shorthand for:
            // InkLevel = InkLevel - (percentagePerCharacter * characterCount)
            // Our getter does rounding, so it creates invalid results.
            // To get around this, on the getting part, we go directly to the backing variable.
            // But we keep the property in the setting part so that we don't bypass our validation.
            InkLevel = _inkLevel - (Percentage * LengthOfmyString1);
        }
        // Borrowed code from james (Challege 1)
        public override string ToString()
        {
            return $"This is a {InkColor} {Brand} pen {(HasLid ? "with" : "without")} a lid with approximately {InkLevel}% of the ink remaining.";
        }

        // other Way 
        /*
        public void Write(int characterCount)
        {
            // 0.05 ML for 10 char
        double percentageChar =( 0.05/MaxInk)*100;
        //InkLevel -= percentageChar * characterCount;
        InkLevel =_inkLevel -( percentageChar * characterCount);
        }
        public void Write()
        {
        double percentageChar =( 0.05/MaxInk)*100;
        InkLevel -= percentageChar *10;
        //We can use only Write(10); to remove redundant code..
        }
        */
    }
}
