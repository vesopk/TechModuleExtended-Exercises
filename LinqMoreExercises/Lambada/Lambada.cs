using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambada
{
    class Lambada
    {
        public static void Main()
        {
            var inputline = Console.ReadLine();
            Dictionary<string,Dictionary<string,string>> lambadaDictionary = new Dictionary<string, Dictionary<string, string>>();
            while (inputline!="lambada")
            {
                var inputLineParams = inputline.Split(new[] {' ', '=', '>', '.'}, StringSplitOptions.RemoveEmptyEntries);
                if (inputline!="dance")
                {
                    var selector = inputLineParams[0];
                    var selectorObject = inputLineParams[1];
                    var property = inputLineParams[2];
                    if (!lambadaDictionary.ContainsKey(selector))
                    {
                        lambadaDictionary[selector] = new Dictionary<string, string>();
                    }
                    if (!lambadaDictionary[selector].ContainsKey(selectorObject))
                    {
                        lambadaDictionary[selector][selectorObject] = property;
                    }
                    lambadaDictionary[selector][selectorObject] = property;
                }
                else
                {
                    lambadaDictionary = lambadaDictionary
                        .ToDictionary(selector => selector.Key, selector => selector.Value
                            .ToDictionary(selectorObject => selectorObject.Key,
                                selectorObject => selectorObject.Key + "." + selectorObject.Value));
                }
                inputline = Console.ReadLine();
            }
            foreach (var selector in lambadaDictionary.Keys)
            {
                foreach (var selectorObject in lambadaDictionary[selector])
                {
                    Console.WriteLine($"{selector} => {selectorObject.Key}.{selectorObject.Value}");
                }
            }
        }
    }
}
