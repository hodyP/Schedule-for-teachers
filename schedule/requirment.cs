using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schedule
{   
    public class Requirment:Label
    {
        public string ClassName { get; set; }
        public string TeacherName { get; set; }       
        public string SubjectName { get; set; }
        public int Num { get; set; }
        public int myLeft = 40;
        public int MyTop { get; set; }

        public Requirment()
        {
            style();           
        }
        private void style()
        {
            this.BorderStyle = BorderStyle.Fixed3D;
            this.BackColor = Color.LightBlue;
            this.Width = 90;
            this.Height = 50;
            this.Left = myLeft;
        }
        public void rename()
        {
            this.Text = TeacherName + "\n" + SubjectName;
        }
        public void replace()
        {
            this.Top = MyTop;
        }
        public Requirment(Requirment r)
        {
            this.ClassName = r.ClassName;
            this.TeacherName = r.TeacherName;
            this.SubjectName = r.SubjectName;
            MyTop = r.MyTop;
            this.Top = MyTop;
            this.rename();
            style();            
        }
    }
}
