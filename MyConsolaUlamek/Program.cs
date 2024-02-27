using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsolaUlamek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ulamek a = new Ulamek(5, 4);
            Ulamek b = new Ulamek(7, 4);
            Ulamek c =a * b;

            Console.Write(c.ToString());
            //Ulamek c = Ulamek.Polowa;
            //Ulamek d = Ulamek.cwiarc;

            //Console.WriteLine((a+b).ToString());
            //Console.WriteLine((c/b).ToString());

            //Ulamek[] tablicaUlamkow = new Ulamek(10);

        }
    }
}
