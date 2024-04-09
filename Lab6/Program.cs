using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Książka> książki = Książka.GenerujKsiążki();
            Książka.Print(książki);
            Console.WriteLine("\r\n");



            //Znajdź wszystkie książki wydane po roku 2000
            Console.WriteLine("Znajdź wszystkie książki wydane po roku 2000:");
            var ksiazkiNowe = książki.Where(p => p.RokWydania > 2000);
            Książka.Print(ksiazkiNowe);
            Console.WriteLine("\r\n");



            //Znajdź średnią ocenę wszystkich książek:
            Console.WriteLine("Znajdź średnią ocenę wszystkich książek:");
            var sredniaOcena = książki.Average(p => p.Ocena);
            Console.WriteLine(sredniaOcena);
            Console.WriteLine("\r\n");



            // Znajdź 3 najlepiej ocenione książki
            Console.WriteLine("Znajdź 3 najlepiej ocenione książki:");
            var najlepsze = książki.OrderByDescending(p => p.Ocena).Take(3);
            Książka.Print(najlepsze);
            Console.WriteLine("\r\n");


            //Posortuj książki według roku wydania
            Console.WriteLine("Posortuj książki według roku wydania:");
            var książkiOrderYear = książki.OrderBy(p => p.RokWydania);
            Książka.Print(książkiOrderYear);
            Console.WriteLine("\r\n");


            //Znajdź najstarszą i najnowszą książkę w bazie.
            Console.WriteLine("Znajdź najstarszą i najnowszą książkę w bazie:");
            var książkaStara = książki.OrderBy(p => p.RokWydania).Take(1);
            var książkaNowa = książki.OrderByDescending(p => p.RokWydania).Take(1);
            Książka.Print(książkaStara);
            Książka.Print(książkaNowa);
            Console.WriteLine("\r\n");


            //Znajdź wszystkie unikalne gatunki książek obecne w bazie.
            Console.WriteLine("Znajdź wszystkie unikalne gatunki książek obecne w bazie:");
            var unikalne = książki.GroupBy(p => p.Gatunek);
            Console.WriteLine("\r\n");

            


            //Znajdź wszystkie książki napisane przez danego autora
            Console.WriteLine("Znajdź wszystkie książki napisane przez danego autora");
            var książkiAutora = książki.Where(p => p.Autor == "Emily Bronte");
            Książka.Print(książkiAutora);
            Console.WriteLine("\r\n");


            Thread.Sleep(1000000);
        }

    }
    
}

