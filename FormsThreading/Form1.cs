using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsThreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int iloscWatkowDoUruchomienia = 0;
        int iloscAktualnieUruchomionychWatkow = 0;
        

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelTrackbar.Text = trackBar1.Value.ToString();
            label2.Text = iloscAktualnieUruchomionychWatkow.ToString();
            iloscWatkowDoUruchomienia = trackBar1.Value;

            do
            {
                Thread someThread = new Thread(CialoWatku);
                someThread.Start();
            } while(iloscAktualnieUruchomionychWatkow < iloscWatkowDoUruchomienia);
        }


        void CialoWatku ()
        {
            iloscAktualnieUruchomionychWatkow++;
            bool isRunning = true;

            do
            {
                if(iloscAktualnieUruchomionychWatkow > iloscWatkowDoUruchomienia)
                {
                    isRunning = false;
                }
            } while (isRunning==true);
            Thread.Sleep(10000);


        }
    }
}
