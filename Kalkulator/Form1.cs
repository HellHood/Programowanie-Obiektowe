using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void PrzyciskDodaj_Click(object sender, EventArgs e)
        //{
        //    poleWyjsciowe.Value = poleWejsciowe1.Value + poleWejsciowe2.Value;
        //}

        //private void PrzyciskOdejmowanie_Click(object sender, EventArgs e)
        //{
        //    poleWyjsciowe.Value = poleWejsciowe1.Value - poleWejsciowe2.Value;

        //}

        //private void PrzyciskMnożenie_Click(object sender, EventArgs e)
        //{
        //    poleWyjsciowe.Value = poleWejsciowe1.Value * poleWejsciowe2.Value;

        //}

        //private void PrzyciskDzielenie_Click(object sender, EventArgs e)
        //{
        //    poleWyjsciowe.Value = poleWejsciowe1.Value / poleWejsciowe2.Value;

        //}

        private void button1_Click(object sender, EventArgs e)
        {
            poleLiczbowe1.Text = poleLiczbowe1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            poleLiczbowe1.Text = poleLiczbowe1.Text + "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            poleLiczbowe1.Text = poleLiczbowe1.Text + "3";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            poleLiczbowe1.Text = poleLiczbowe1.Text + "4";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            poleLiczbowe1.Text = poleLiczbowe1.Text + "5";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            poleLiczbowe1.Text = poleLiczbowe1.Text + "6";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            poleLiczbowe1.Text = poleLiczbowe1.Text + "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            poleLiczbowe1.Text = poleLiczbowe1.Text + "8";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            poleLiczbowe1.Text = poleLiczbowe1.Text + "9";

        }

        private void wynik_TextChanged(object sender, EventArgs e)
        {

        }

        int pamiecKalkulatora;
        int wynik;
        private void dodawanie_Click(object sender, EventArgs e)
        {
            int wprowadzonaWartosc = int.Parse(poleLiczbowe1.Text);
            pamiecKalkulatora += wprowadzonaWartosc;
            poleLiczbowe1.Text = null;
            int wynik = wprowadzonaWartosc + pamiecKalkulatora;

        }

        private void przyciskWynik_Click(object sender, EventArgs e)
        {
            int wprowadzonaWartosc = int.Parse(poleLiczbowe1.Text);
            poleWynik.Text = wynik.ToString();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            poleWynik.Text = null;
            poleLiczbowe1.Text = null;
        }
    }
}
