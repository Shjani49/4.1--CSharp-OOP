using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_OOP_Prac
{
   public  class HomeWork
    {
        private int _complexity;
        public int Complexity
        {
            get
            {
                return _complexity; ;
            }
            set
            {
                // If the incoming value is under 1, set it to 1
                if (value < 1)
                {
                    _complexity= 1;
                }
                else
                {
                    if (value > 5)
                    {
                        _complexity = 5;
                    }
                    _complexity = value; ;
                }
            }
        }
    }
}
