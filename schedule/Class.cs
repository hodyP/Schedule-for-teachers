using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace schedule
{
    class Class:IEnumerable,IEnumerator
    { 
        public string Name { get; set; }         
        public int[] days = new int[7];
        List<Requirment> requirments;
        public Class()
        {
            requirments = new List<Requirment>();
        }
        public void Add(Requirment r)
        {
            requirments.Add(r);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
         object IEnumerator.Current
        {
            get
            {
                return requirments[index];
            }
        }
        int index = -1;
        public bool MoveNext()
        {
            index++;
            if (requirments.Count==index)
            {
                ((IEnumerator)this).Reset();
                return false;
            }            
            return true;           
        }
        public void Reset()
        {
            this.index = -1;
        }
    }
}
