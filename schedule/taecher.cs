using System;
using System.Collections.Generic;
using System.Text;

namespace schedule
{
    class Teacher
    {
        public string Name { get; set; }
        
        private bool[][] days = new bool[7][];
        public Teacher()
        {           
            for (int i = 0; i < days.Length; i++)
            {
                days[i] = new bool[10];
                for (int j = 0; j < days[i].Length; j++)
                {
                    days[i][j] = true;
                }
            }
        }
        public bool this[int i,int j]
        {
            get
            {
                return days[i][j];
            }
            set
            {
                days[i][j] = value;
            }
        }
    }
}
