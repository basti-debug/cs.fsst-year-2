using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;


namespace serialisation
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.Sku = "123";
            p.Name = "Test";
            p.Price = 10;
            p.Description = "Beschreibung";

            var options = new JsonSerializerOptions();
            options.WriteIndented = true;
            string jsonString = JsonSerializer.Serialize(p, options);

            string fileName = "Product.json";
            jsonString = File.ReadAllText(fileName);
            Product product = JsonSerializer.Deserialize<Product>(jsonString);

            Console.ReadKey();
        }
    }
}
