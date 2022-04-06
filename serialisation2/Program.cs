using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;


namespace serialisation2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> productList = new List<Product>();
            productList.Add(new Product("1", "Döner", 5.50, "Beschreibung", true));
            productList.Add(new Product("2", "Pommes", 4, "Beschreibung", true));
            productList.Add(new Product("3", "Dürüm", 6.50, "Beschreibung", true));
            productList.Add(new Product("4", "Pizza", 8.50, "Beschreibung", true));
            productList.Add(new Product("5", "Burger", 7, "Beschreibung", true));


            // Speichern der Product-Objekte:
            Save(productList, "student_list.csv");

            // Laden gespeicherten Product-Objekte
            List<Product> studentListLoaded = LoadList("student_list.csv");

            Console.ReadKey();
        }
        static void Save(List<Product> productList, string path)
        {
            // Einen StreamWriter für die angegebene Datei öffnen
            using (StreamWriter stream = new StreamWriter(path, append: false))
            {
                // Über alle Product-Objekte in der Liste iterieren
                foreach (Product product in productList)
                {
                    // Serialisieren des aktuellen Objekts
                    string serializedData = product.SerializeToCsvString();

                    // Schreiben einer neuen Zeile in der Datei           
                    stream.WriteLine(serializedData);
                }
            }
        }

        static List<Product> LoadList(string path)
        {
            List<Product> products = new List<Product>();

            // Einen StreamReader für die angegebene Datei öffnen
            using (StreamReader stream = new StreamReader(path))
            {
                // Weitermachen, solange die Datei nicht am Ende angekommen ist
                while (!stream.EndOfStream)
                {
                    // Nächste Zeile aus der Datei einlesen
                    string serializedData = stream.ReadLine();

                    // Die Daten Deserialisieren            
                    Product product = Product.DeserializeFromCsvString(serializedData);

                    // Das geladene Objekt in die Liste speichern       
                    products.Add(product);
                }
            }

            return products;
        }
    }
}
