using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace schedule
{
    
    public class Inlay:Label
    {
        public int Day { get; set; }
        public int Hour { get; set; }
        public string ClassName { get; set; }       
        public string Teacher { get; set; }
        public string Subject { get; set; }       
        
        public Inlay()
        {
            this.Width =90;
            this.Height = 50;                     
            this.BackColor = System.Drawing.Color.Pink;           
        }      
    }
}
