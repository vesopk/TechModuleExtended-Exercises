using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTime
{
    class ExamTime
    {
        public static void Main()
        {
            var shop = new Dictionary<string,int>();
            var line = Console.ReadLine();

            while (line!="shopping time")
            {
                var tokens = line.Split(' ');
                var product = tokens[1];
                var quantity = int.Parse(tokens[2]);
                if (!shop.ContainsKey(product))
                {
                    shop.Add(product,quantity);
                }
                else
                {
                    shop[product] += quantity;
                }
                line = Console.ReadLine();
            }
            line = Console.ReadLine();
            while (line != "exam time")
            {
                var tokens = line.Split(' ');
                var product = tokens[1];
                var quantity = int.Parse(tokens[2]);
                if (!shop.ContainsKey(product))
                {
                    Console.WriteLine($"{product} doesn't exist");
                }
                else
                {
                    if (shop[product]==0)
                    {
                        Console.WriteLine($"{product} out of stock");
                    }
                    else
                    {
                        shop[product] -= quantity;
                        if (shop[product]<0)
                        {
                            shop[product] = 0;
                        }
                    }
                }
                line = Console.ReadLine();
            }
            foreach (var item in shop)
            {
                var product = item.Key;
                var quantity = item.Value;
                if (quantity>0)
                {
                    Console.WriteLine($"{product} -> {quantity}");
                }
            }

        }
    }
}
