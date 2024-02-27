using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsolaUlamek
{
    internal class Ulamek
    {
        public int licznik;
        public int mianownik;
        public Ulamek(int in_licznik, int in_mianownik) {
            
            if(in_mianownik == 0)
            {
                throw new Exception("Nie dzielimy przez 0");
            }
            licznik = in_licznik;
            mianownik = in_mianownik;
        }

        public void Uprosc()
        {

        }

        public override string ToString()
        {
            return licznik.ToString()+"/"+mianownik.ToString();
        }
        public static Ulamek operator*(Ulamek valueA, Ulamek valueB)
        {
            Ulamek wynik = new Ulamek(valueA.licznik * valueB.licznik,valueB.mianownik  * valueB.mianownik);
            wynik.Uprosc();
            return wynik;
        }

        public static Ulamek operator+(Ulamek valueA, Ulamek valueB)
        {
            
        }
    }
}
