using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicRefAdvanced
{
    class DicRefAdvanced
    {
        public static void Main()
        {
            Dictionary<string,List<int>> dictionary = new Dictionary<string, List<int>>();
            var inputLine = Console.ReadLine();
            while (inputLine!="end")
            {
                var inputParams = inputLine.Split(new[] {' ', '-', '>', ','}, StringSplitOptions.RemoveEmptyEntries);
                var firstValue = -1;
                var currentKey = inputParams[0];
                if (int.TryParse(inputParams[1],out firstValue))
                {
                    if (!dictionary.ContainsKey(currentKey))
                    {
                        dictionary[currentKey] = new List<int>();
                    }
                    for (int i = 1; i < inputParams.Length; i++)
                    {
                        dictionary[currentKey].Add(int.Parse(inputParams[i]));
                    }
                }
                else
                {
                    var otherKey = inputParams[1];
                    if (dictionary.ContainsKey(otherKey))
                    {
                        dictionary[currentKey] = new List<int>(dictionary[otherKey]);
                    }
                }
                inputLine = Console.ReadLine();
            }
            foreach (var entry in dictionary)
            {
                Console.WriteLine($"{entry.Key} === {string.Join(", ",entry.Value)}");
            }
        }
    }

}
