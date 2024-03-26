using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentrumPowiadomień
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        delegate void NaszDelegata(string wiadomosc);

        NaszDelegata naszaZmiennaDelegaty;

        private void send_Click(object sender, EventArgs e)
        {
            if (naszaZmiennaDelegaty != null)
            {
                naszaZmiennaDelegaty(powiadomienie.Text);

            }
        }

        void DodanieInformacjiDoOkienkaPolicji(string dane)
        {
            powiadomieniaPolicji.Text += dane + "\r\n";
        }
        void DodanieInformacjiDoOkienkaPogotowia(string dane)
        {
            powiadomieniaPogotowie.Text += dane + "\r\n";
        }
        void DodanieInformacjiDoOkienkaStrazy(string dane)
        {
            powiadomieniaStraz.Text += dane + "\r\n";
        }

        private void policja_CheckedChanged(object sender, EventArgs e)
        {
            if (policja.CheckState == CheckState.Checked)
            {
                naszaZmiennaDelegaty += DodanieInformacjiDoOkienkaPolicji;

            }
        }

        private void Pogotowie_CheckedChanged(object sender, EventArgs e)
        {
            if (Pogotowie.CheckState == CheckState.Checked)
            {
                naszaZmiennaDelegaty += DodanieInformacjiDoOkienkaPogotowia;

            }

        }


        private void straz_CheckedChanged(object sender, EventArgs e)
        {
            if (straz.Checked == true)
            {
                naszaZmiennaDelegaty += DodanieInformacjiDoOkienkaStrazy;

            }

        }

        private void powiadomienie_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
