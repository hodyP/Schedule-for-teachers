using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace schedule
{
    public partial class ClassSchedule : Form
    {
        List<Inlay> inlays = new List<Inlay>();
        List<Requirment> Requ = new List<Requirment>();
        public ClassSchedule()
        {
            InitializeComponent();
            
        }

        private void ClassSchedule_Load(object sender, EventArgs e)
        {

        }
    }
}
