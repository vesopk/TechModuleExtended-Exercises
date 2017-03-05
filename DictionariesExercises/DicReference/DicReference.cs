using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicReference
{
    class DicReference
    {
        public static void Main()
        {
            var dicRef = new Dictionary<string, int>();
            while (true)
            {
                var command = Console.ReadLine().Split(new[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "end")
                {
                    foreach (var item in dicRef)
                    {
                        Console.WriteLine($"{item.Key} === {item.Value}");
                    }
                    break;
                }
                var name = command[0];
                var value = command[1];
                var isAllString = true;
                try
                {
                    var valueToInt = int.Parse(value);
                    isAllString = false;
                }
                catch (Exception)
                {
                    // ignored
                }
                if (!isAllString)
                {
                    var valueToInt = int.Parse(value);
                    if (!dicRef.ContainsKey(name))
                    {
                        dicRef.Add(name, valueToInt);
                    }
                    else if (dicRef.ContainsKey(name))
                    {
                        dicRef[name] = valueToInt;
                    }
                }
                else
                {
                    if (dicRef.ContainsKey(value))
                    {
                        dicRef[name] = dicRef[value];
                    }
                }
            }
        }
    }

}
