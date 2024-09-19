using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace schedule
{   
    class ButtonClass: Button
    {
        static int left=100;
        static int top=50;       
        
        public ButtonClass()
        {
            style();                      
        }

        private void style()
        {
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Left = left;
            this.Top = top;
            top += 50;
            left += 70;
        }
    }
}
