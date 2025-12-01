using Newtonsoft.Json;

namespace ConsoleApp
{
    internal class Product
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string CategoryName { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static Product FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Product>(json);
        }
    }
}
