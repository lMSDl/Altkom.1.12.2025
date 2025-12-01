// See https://aka.ms/new-console-template for more information
using ConsoleApp;
using Newtonsoft.Json;

Console.WriteLine("Hello, World!");

var calculator = new Calculator();

List<Product> products = GetProducts();

// Serializacja pierwszego produktu do JSON
string json = products[0].ToJson();
Console.WriteLine($"Serialized Product to JSON:\n{json}\n");

// Deserializacja z JSON do obiektu Product
Product deserializedProduct = Product.FromJson(json);
Console.WriteLine($"Deserialized Product:\nName: {deserializedProduct.ProductName}, Price: {deserializedProduct.Price}, Description: {deserializedProduct.Description}, Category: {deserializedProduct.Category}, CategoryName: {deserializedProduct.CategoryName}\n");

//create function that return 5 objects of Product class
List<ConsoleApp.Product> GetProducts()
{
    return new List<ConsoleApp.Product>
    {
        new ConsoleApp.Product { ProductName = "Laptop", Price = 999.99m, Description = "High performance laptop", Category = "Electronics", CategoryName = "Computers" },
        new ConsoleApp.Product { ProductName = "Smartphone", Price = 699.99m, Description = "Latest model smartphone", Category = "Electronics", CategoryName = "Mobile Phones" },
        new ConsoleApp.Product { ProductName = "Headphones", Price = 199.99m, Description = "Noise cancelling headphones", Category = "Electronics", CategoryName = "Audio" },
        new ConsoleApp.Product { ProductName = "Coffee Maker", Price = 49.99m, Description = "Automatic coffee maker", Category = "Home Appliances", CategoryName = "Kitchen" },
        new ConsoleApp.Product { ProductName = "Electric Kettle", Price = 29.99m, Description = "Fast boiling electric kettle", Category = "Home Appliances", CategoryName = "Kitchen" },
        new ConsoleApp.Product { ProductName = "Desk Lamp", Price = 39.99m, Description = "LED desk lamp with adjustable brightness", Category = "Home Appliances", CategoryName = "Lighting" }
    };
}

Point3D CreatePoint3D(float[] tab)
{
    if(tab.Length < 3)
    {
        throw new ArgumentException("Array must contain at least three elements to create a Point3D.");
    }

    Console.WriteLine("creating new point3D using tab");

    return new Point3D(tab[0], tab[1], tab[2]);
}