using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        delegate void NaszDelegat(string dane);

        static void Funkcja1(string dane)
        {
            Console.WriteLine($" jestem Funkcja 1,{dane}");
        }
        static void Funkcja2(string dane)
        {
            Console.WriteLine($" jestem Funkcja 2,{dane}");
        }
        static void Main(string[] args)
        {
            NaszDelegat delegat1, delegat2, multiDelegat, zmodyfikowanyDelegat;

            Console.WriteLine("Cześć");

            delegat1 = Funkcja1;
            delegat2 = Funkcja2;
            multiDelegat = delegat1 + delegat2;
            zmodyfikowanyDelegat = multiDelegat - delegat1;

            Console.WriteLine("delegat delegat1");
            delegat1("jestem pierwszy");

            Console.WriteLine("delegat delegat2");
            delegat2("jestem drugi");

            Console.WriteLine("delegat multidelegat");
            multiDelegat("Jestem multidelegatem");

            Console.WriteLine("zmodyfikowany");
            zmodyfikowanyDelegat("Jestem zmodyfikowanym delegatem");

            Thread.Sleep(10000);
        }
    }
}
