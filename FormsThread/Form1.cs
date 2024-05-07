using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void run_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            labelClock.Text = dateTime.ToString();
        }

        DateTime startAplikacji = DateTime.Now;

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            labelClock.Text = dateTime.ToString();

            long tick = DateTime.Now.Ticks - startAplikacji.Ticks;
        }
    }
}
