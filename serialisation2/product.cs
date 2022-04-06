using System;

public class product
{
    public string Sku { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public bool LimitedEdition { get; set; }

    public Product(string sku, string name, double price, string description, bool limitedEdition)
    {
        Sku = sku;
        Name = name;
        Price = price;
        Description = description;
        LimitedEdition = limitedEdition;

    }

    public string SerializeToCsvString()
    {
        // Convert the properties to a ";" separated string
        string serialized = $"{Sku};{Name};{Price};{Description};{LimitedEdition}";
        return serialized;
    }

    public static Product DeserializeFromCsvString(string serialized)
    {
        // Split the string according to the used delimiter
        string[] fields = serialized.Split(';');

        // Create a new product using the provided data
        Product product = new Product(fields[0], fields[1], double.Parse(fields[2]), fields[3], bool.Parse(fields[4]));
        return product;
    }

    static void Save(Product product, string path)
    {
        // Open a new file stream to write into a text file
        using (StreamWriter stream = new StreamWriter(path, append: false))
        {
            // Serialize the product
            string serializedData = product.SerializeToCsvString();

            // Write the data to the file        
            stream.WriteLine(serializedData);
        }
    }

    static Product Load(string path)
    {
        Product product = null;

        // Load from file
        using (StreamReader stream = new StreamReader(path))
        {
            // Get the first line of the text file (csv)
            string serializedData = stream.ReadLine();

            // Deserialize the string        
            product = Product.DeserializeFromCsvString(serializedData);
        }

        return product;
    }
}
