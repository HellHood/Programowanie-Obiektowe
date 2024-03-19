using KelnerRestauracja;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restauracja
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        ListaZamowien listaZamowien = new ListaZamowien();

        private void button1_Click_1(object sender, EventArgs e)
        {
            Zamowienie nowezamowienie = new Zamowienie();
            nowezamowienie.cenaZamowienia = decimal.Parse(dataInCena.Text);
            nowezamowienie.zamowienie = dataInZamowienie.Text;
            nowezamowienie.nrStolika = (int)dataInNrStolika.Value;

            listaZamowien.listaZamowienie.Add(nowezamowienie);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataOutListaDan.Items.Clear();

            foreach (Zamowienie zamowienie in listaZamowien.listaZamowienie)
            {
                dataOutListaDan.Items.Add(zamowienie.zamowienie);
            }
        }

        private void dataInNrStolika_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}