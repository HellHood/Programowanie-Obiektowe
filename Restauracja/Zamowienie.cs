using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace KelnerRestauracja
{
    internal class Zamowienie //: IEnumerable<int>
    {
        public int nrStolika;
        public string zamowienie;
        public decimal cenaZamowienia;
    }
 
    class ListaZamowien
    {
        public List<Zamowienie> listaZamowienie = new List<Zamowienie>();
    }
}