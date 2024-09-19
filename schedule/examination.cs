using System;
using System.Collections.Generic;
using System.Text;

namespace schedule
{
    public delegate void EventExamination(Examination e);
    public class Examination
    {
        public Inlay inlay;
        public Requirment requirment ;
        public event EventExamination bothFull;
        public Examination()
        {
            
        }
        public void insert_inlay(Inlay i)
        {
            this.inlay = i;
            if (this.requirment != null)
                bothFull?.Invoke(this);

        }
        public void insert_requirment(Requirment r)
        {
            this.requirment = r;
            if (this.inlay != null)
                bothFull?.Invoke(this);
        }       
    }
}
