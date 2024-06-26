using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace SerializeDeserialize
{
    // Klasa reprezentująca kolekcję liczb całkowitych
    [Serializable]
    public class IntCollection : IEnumerable<int>
    {
        private List<int> numbers = new List<int>();

        // Metoda dodająca liczbę do kolekcji
        public void Add(int number)
        {
            numbers.Add(number);
        }

        // Metoda interfejsu IEnumerable<int> zwracająca iterator do kolekcji
        public IEnumerator<int> GetEnumerator()
        {
            return numbers.GetEnumerator();
        }

        // Metoda interfejsu IEnumerable zwracająca iterator do kolekcji
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Utwórz kolekcję liczb całkowitych
            IntCollection collection = new IntCollection();
            collection.Add(9);
            collection.Add(2);
            collection.Add(3);
            collection.Add(7);
            collection.Add(5);

            // Serializacja kolekcji do pliku
            SerializeObject("D:\\Users\\mmietka\\Desktop\\data\\collection.xml", collection);

            // Deserializacja kolekcji z pliku
            IntCollection deserializedCollection = DeserializeObject<IntCollection>("D:\\Users\\mmietka\\Desktop\\data\\collection.xml");

            // Wyświetlenie zawartości deserializowanej kolekcji
            Console.WriteLine("Deserialized Collection:");
            foreach (int number in deserializedCollection)
            {
                Console.WriteLine(number);
            }
        }

        // Metoda do serializacji obiektu do pliku XML
        static void SerializeObject<T>(string filename, T obj)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (TextWriter writer = new StreamWriter(filename))
            {
                serializer.Serialize(writer, obj);
            }
            Console.WriteLine($"Serialized {typeof(T).Name} object to {filename}");
        }

        // Metoda do deserializacji obiektu z pliku XML
        static T DeserializeObject<T>(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (TextReader reader = new StreamReader(filename))
            {
                return (T)serializer.Deserialize(reader);
            }
        }
    }

}