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
    public delegate void EventMain(Button b);
    public partial class MainForm : Form
    {
        public event EventMain finish;
        public MainForm()
        {
            InitializeComponent();       
        }
        private void Fuatzx(List<Class> c)
        {
            foreach (var item in c)
            {
                ButtonClass b = new ButtonClass();
                b.Text = item.Name ;
                
            }
        }              

        
        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("yesh");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            finish?.Invoke(button1);
        }
    }
}
