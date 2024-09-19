using schedule;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace schedule
{
    abstract class Constrate
    {
        public abstract bool check(Examination e);
        public virtual void insert(Examination e) { }
        public virtual void delete(Examination e) { }

    }

    //1
    class ConTeacherHours : Constrate
    {
        public bool[,] hours = new bool[7, 10];
        public string name;

        public override bool check(Examination e)
        {
            if (hours[e.inlay.Day, e.inlay.Hour] == false)
            {
                MessageBox.Show(name + " can't teach on this day at this hour");
                return false;
            }
            return true;
        }        
    }


    //2
    class ConTeacherMax : Constrate
    {
        public string name;
        int min;
        int max;
        int[] count =new int[7];
        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                if (value < 9 && value > 1 && value <= max)
                    min = value;
            }
        }
        public int Max
        {
            get
            {
                return max;
            }
            set
            {
                if (value < 9 && value > 1 && value >= min)
                    max = value;
            }
        }

        public override bool check(Examination e)
        {
            if (count[e.inlay.Day] == max)
            {
                MessageBox.Show(name + " already teaches maximum hours this day");
                return false;
            }
            return true;
        }

        public override void delete(Examination e)
        {
            count[e.inlay.Day]--;
        }

        public override void insert(Examination e)
        {
            count[e.inlay.Day]++;
        }
    }


    //3
    class ConSubject : Constrate
    {
        public string Name { get; set; }
        public int Nim { get; set; }
        public int Max { get; set; }
        List<string>[,] r = new List<string>[7,9];       
        public ConSubject()
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    r[i, j] = new List<string>();
                }
            }
        } 
        public override bool check(Examination e)
        {
            bool[] check1 = new bool[10];
            for (int i =1; i <= Max; i++)
            {
                if (e.inlay.Hour - i > 0)
                {
                    foreach (var item in r[e.inlay.Day, e.inlay.Hour - i])
                    {
                        if (item == e.inlay.ClassName)
                        {
                            check1[i] = true;
                            break;
                        }
                    }
                }
                if (e.inlay.Hour + i < 10)
                {
                    foreach (var item in r[e.inlay.Day, e.inlay.Hour + i])
                    {
                        if (item == e.inlay.ClassName)
                        {
                            check1[i] = true;
                            break;
                        }
                    }
                }                                   
            }
            check1[e.inlay.Hour] = true;
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                if (check1[i] == true)
                    count++;
                else
                    count = 0;
                if(count>Max)
                {
                    MessageBox.Show("It is not possible to have more than "+Max+" consecutive "+Name+" lessons");
                    return false;
                }
            }
            return true;   
        }
            
    
        public override void delete(Examination e)
        {
            r[e.inlay.Day, e.inlay.Hour].Remove(e.inlay.ClassName);
        }
        public override void insert(Examination e)
        {
            r[e.inlay.Day, e.inlay.Hour].Add(e.inlay.ClassName);
        }
    }


    //4
    class ConSubjectPossibility : Constrate
    {
        public string name;
        public List<int> whenTeach = new List<int>();
        public override bool check(Examination e)
        {
            foreach (var item in whenTeach)
            {
                if (item == e.inlay.Hour)
                    return true;
            }
            MessageBox.Show("This subject cannot be taught at " + (e.inlay.Hour + 7) + "o'clock");
            return false;
        }
    }


    //5
    class ConSubjectNoPossibility : Constrate
    {
        public string name;
        public List<int> whenNotTeach = new List<int>();
        public override bool check(Examination e)
        {
            foreach (var item in whenNotTeach)
            {
                if (item == e.inlay.Hour)
                {
                    MessageBox.Show("This subject cannot be taught at " + (e.inlay.Hour + 7) + "o'clock");
                    return false;
                }
            }
            return true;
        }
    }
}
