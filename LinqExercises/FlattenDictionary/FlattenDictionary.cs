using System;
using System.Collections.Generic;
using System.Linq;

namespace FlattenDictionary
{
    class FlattenDictionary
    {
        public static void Main()
        {
            Dictionary<string,Dictionary<string,string>> dictionary = new Dictionary<string, Dictionary<string, string>>();
            var input = Console.ReadLine();
            while (input!="end")
            {
                var inputParams = input.Split(' ');
                var type = inputParams[0];
                if (type != "flatten")
                {

                    var brand = inputParams[1];
                    var model = inputParams[2];
                    if (!dictionary.ContainsKey(type))
                    {
                        dictionary[type] = new Dictionary<string, string>();
                    }
                    dictionary[type][brand] = model;
                }
                else
                {
                    var key = inputParams[1];
                    dictionary[key] = dictionary[key].ToDictionary(x => x.Key + x.Value, x => "flattened");
                }
                input = Console.ReadLine();
            }
            Dictionary<string, Dictionary<string, string>> orderedDictionary =
                dictionary
                    .OrderByDescending(x => x.Key.Length)
                    .ToDictionary(x => x.Key, x => x.Value);
            foreach (var entry in orderedDictionary)
            {
                Console.WriteLine("{0}",entry.Key);
                Dictionary<string, string> orderedInnerDictionary =
                    entry.Value.Where(x => x.Value!= "flattened").OrderBy(x => x.Key.Length).ToDictionary(x => x.Key, x => x.Value);
                Dictionary<string, string> flattenedValuesDictionary =
                    entry
                        .Value.Where(x => x.Value == "flattened")
                        .ToDictionary(x => x.Key, x => x.Value);
                var i = 1;
                foreach (var innerEntry in orderedInnerDictionary)
                {
                    
                    Console.WriteLine("{0}. {1} - {2}",i,innerEntry.Key,innerEntry.Value);
                    i++;
                }
                foreach (var flattenedEntry in flattenedValuesDictionary)
                {
                    Console.WriteLine("{0}. {1}",i,flattenedEntry.Key);
                    i++;
                }
            }
        }
    }
}
