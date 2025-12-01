// See https://aka.ms/new-console-template for more information
using ConsoleApp;

Console.WriteLine("Hello, World!");

var calculator = new Calculator();

// Example usage (can be removed or modified as needed)
// int sum = calculator.Sum(2, 3);
// int sub = calculator.Subtract(5, 2);
// int mul = calculator.Multiply(2.5f, 4.0f);
// float div = calculator.Divide(10, 2);

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