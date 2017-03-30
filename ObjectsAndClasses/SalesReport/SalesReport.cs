using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesReport
{
    class SalesReport
    {
       public static void Main()
       {
           var n = int.Parse(Console.ReadLine());
           var result = new Dictionary<string, decimal>();
           for (int i = 0; i < n; i++)
           {
               var lineData = Console.ReadLine();
               var currentSale = Sale.Parse(lineData);
               if (!result.ContainsKey(currentSale.Town))
               {
                   result[currentSale.Town] = 0;
               }
               result[currentSale.Town] += currentSale.SumPrice;
           }
           foreach (var sale in result.OrderBy(s => s.Key))
           {
               Console.WriteLine($"{sale.Key} -> {sale.Value:F2}");
           }
       }
    }
}

class Sale
{
    public string Town { get; set; }
    public string Product { get; set; }
    public decimal Price { get; set; }
    public decimal Quantity { get; set; }

    public static Sale Parse(string saleAsString)
    {
        var saleParts = saleAsString.Split(' ');
        return new Sale()
        {
            Town = saleParts[0],
            Product = saleParts[1],
            Price = decimal.Parse(saleParts[2]),
            Quantity = decimal.Parse(saleParts[3])
        };
    }
    public decimal SumPrice => Quantity * Price;
}
