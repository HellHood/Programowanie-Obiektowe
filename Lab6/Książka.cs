using Lab6;
using System;
using System.Collections.Generic;

    public class Książka
    {
            public string Tytuł { get; set; }
            public string Autor { get; set; }
            public int RokWydania { get; set; }
            public string Gatunek { get; set; }
            public double Ocena { get; set; }





            public static void Print(IEnumerable<Książka> książki)
            {
                foreach (var książka in książki)
                {
                    Console.WriteLine($"Tytuł: {książka.Tytuł}, Autor: {książka.Autor}, Rok wydania: {książka.RokWydania}, Gatunek: {książka.Gatunek}, Ocena: {książka.Ocena}");
                }
            }



            public static List<Książka> GenerujKsiążki()
            {
                List<Książka> książki = new List<Książka>();



                książki.Add(new Książka { Tytuł = "Harry Potter and the Philosopher's Stone", Autor = "J.K. Rowling", RokWydania = 1997, Gatunek = "Fantasy", Ocena = 4.5 });
                książki.Add(new Książka { Tytuł = "To Kill a Mockingbird", Autor = "Harper Lee", RokWydania = 1960, Gatunek = "Dramat", Ocena = 4.8 });
                książki.Add(new Książka { Tytuł = "1984", Autor = "George Orwell", RokWydania = 1949, Gatunek = "Science Fiction", Ocena = 4.6 });
                książki.Add(new Książka { Tytuł = "The Catcher in the Rye", Autor = "J.D. Salinger", RokWydania = 1951, Gatunek = "Dramat", Ocena = 4.3 });
                książki.Add(new Książka { Tytuł = "The Great Gatsby", Autor = "F. Scott Fitzgerald", RokWydania = 1925, Gatunek = "Dramat", Ocena = 4.7 });
                książki.Add(new Książka { Tytuł = "Pride and Prejudice", Autor = "Jane Austen", RokWydania = 1813, Gatunek = "Romans", Ocena = 4.8 });
                książki.Add(new Książka { Tytuł = "The Hobbit", Autor = "J.R.R. Tolkien", RokWydania = 1937, Gatunek = "Fantasy", Ocena = 4.9 });
                książki.Add(new Książka { Tytuł = "The Lord of the Rings", Autor = "J.R.R. Tolkien", RokWydania = 1954, Gatunek = "Fantasy", Ocena = 4.9 });
                książki.Add(new Książka { Tytuł = "The Chronicles of Narnia", Autor = "C.S. Lewis", RokWydania = 1950, Gatunek = "Fantasy", Ocena = 4.6 });
                książki.Add(new Książka { Tytuł = "To the Lighthouse", Autor = "Virginia Woolf", RokWydania = 1927, Gatunek = "Fikcja literacka", Ocena = 4.2 });
                książki.Add(new Książka { Tytuł = "Moby-Dick", Autor = "Herman Melville", RokWydania = 1851, Gatunek = "Przygodowy", Ocena = 4.4 });
                książki.Add(new Książka { Tytuł = "Crime and Punishment", Autor = "Fyodor Dostoevsky", RokWydania = 1866, Gatunek = "Dramat", Ocena = 4.7 });
                książki.Add(new Książka { Tytuł = "The Picture of Dorian Gray", Autor = "Oscar Wilde", RokWydania = 1890, Gatunek = "Fantasy", Ocena = 4.5 });
                książki.Add(new Książka { Tytuł = "Wuthering Heights", Autor = "Emily Bronte", RokWydania = 1847, Gatunek = "Dramat", Ocena = 4.6 });
                książki.Add(new Książka { Tytuł = "Anna Karenina", Autor = "Leo Tolstoy", RokWydania = 1877, Gatunek = "Dramat", Ocena = 4.7 });
                książki.Add(new Książka { Tytuł = "Gone with the Wind", Autor = "Margaret Mitchell", RokWydania = 1936, Gatunek = "Dramat", Ocena = 4.6 });
                książki.Add(new Książka { Tytuł = "Don Quixote", Autor = "Miguel de Cervantes", RokWydania = 1605, Gatunek = "Przygodowy", Ocena = 4.5 });
                książki.Add(new Książka { Tytuł = "The Count of Monte Cristo", Autor = "Alexandre Dumas", RokWydania = 1844, Gatunek = "Przygodowy", Ocena = 4.7 });
                książki.Add(new Książka { Tytuł = "Frankenstein", Autor = "Mary Shelley", RokWydania = 1818, Gatunek = "Science Fiction", Ocena = 4.3 });
                książki.Add(new Książka { Tytuł = "Dracula", Autor = "Bram Stoker", RokWydania = 1897, Gatunek = "Horror", Ocena = 4.4 });
                książki.Add(new Książka { Tytuł = "Les Misérables", Autor = "Victor Hugo", RokWydania = 1862, Gatunek = "Dramat", Ocena = 4.7 });
                książki.Add(new Książka { Tytuł = "Jane Eyre", Autor = "Charlotte Bronte", RokWydania = 1847, Gatunek = "Romans", Ocena = 4.8 });
                książki.Add(new Książka { Tytuł = "War and Peace", Autor = "Leo Tolstoy", RokWydania = 1869, Gatunek = "Dramat", Ocena = 4.7 });
                książki.Add(new Książka { Tytuł = "The Odyssey", Autor = "Homer", RokWydania = -800, Gatunek = "Epos", Ocena = 4.6 });
                książki.Add(new Książka { Tytuł = "The Iliad", Autor = "Homer", RokWydania = -800, Gatunek = "Epos", Ocena = 4.6 });
                książki.Add(new Książka { Tytuł = "The Divine Comedy", Autor = "Dante Alighieri", RokWydania = 1320, Gatunek = "Poemat epicki", Ocena = 4.7 });
                książki.Add(new Książka { Tytuł = "The Canterbury Tales", Autor = "Geoffrey Chaucer", RokWydania = 1400, Gatunek = "Opowieści", Ocena = 4.5 });
                książki.Add(new Książka { Tytuł = "The Adventures of Huckleberry Finn", Autor = "Mark Twain", RokWydania = 1884, Gatunek = "Przygodowy", Ocena = 4.4 });
                książki.Add(new Książka { Tytuł = "Alice's Adventures in Wonderland", Autor = "Lewis Carroll", RokWydania = 1865, Gatunek = "Fantasy", Ocena = 4.6 });
                książki.Add(new Książka { Tytuł = "The War of the Worlds", Autor = "H.G. Wells", RokWydania = 1898, Gatunek = "Science Fiction", Ocena = 4.3 });
                książki.Add(new Książka { Tytuł = "The Adventures of Sherlock Holmes", Autor = "Arthur Conan Doyle", RokWydania = 1892, Gatunek = "Detektywistyczny", Ocena = 4.7 });
                książki.Add(new Książka { Tytuł = "Little Women", Autor = "Louisa May Alcott", RokWydania = 1868, Gatunek = "Dramat", Ocena = 4.5 });
                książki.Add(new Książka { Tytuł = "Brave New World", Autor = "Aldous Huxley", RokWydania = 1932, Gatunek = "Science Fiction", Ocena = 4.4 });
                książki.Add(new Książka { Tytuł = "One Hundred Years of Solitude", Autor = "Gabriel García Márquez", RokWydania = 1967, Gatunek = "Fantasy", Ocena = 4.6 });
                książki.Add(new Książka { Tytuł = "Catch-22", Autor = "Joseph Heller", RokWydania = 1961, Gatunek = "Satyra", Ocena = 4.3 });
                książki.Add(new Książka { Tytuł = "The Grapes of Wrath", Autor = "John Steinbeck", RokWydania = 1939, Gatunek = "Dramat", Ocena = 4.7 });
                książki.Add(new Książka { Tytuł = "The Bell Jar", Autor = "Sylvia Plath", RokWydania = 1963, Gatunek = "Autobiografia", Ocena = 4.5 });



                return książki;
            }
        }
    