
namespace _003._Product_Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ProductShop
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            var dictShop = new Dictionary<string, Dictionary<string, double>>();
            //Fill dictShop
            while ((input = Console.ReadLine()) != "Revision")
            {
                var inputSplit = input.Split(", ",StringSplitOptions.RemoveEmptyEntries);
                var shopName = inputSplit[0];
                var productType = inputSplit[1];
                var productPrice = double.Parse(inputSplit[2]);

                if (!dictShop.ContainsKey(shopName))
                {
                    dictShop.Add(shopName, new Dictionary<string, double>());
                }
                dictShop[shopName].Add(productType, productPrice);
            }

            // Print Result
            foreach (var dictionary in dictShop.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{dictionary.Key}->");
                foreach (var kvp in dictionary.Value)
                {
                    Console.WriteLine($"Product: {kvp.Key}, Price: {kvp.Value:f1}");
                }
            }
        }
    }
}
