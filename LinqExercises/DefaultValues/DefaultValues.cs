using System;
using System.Collections.Generic;
using System.Linq;

namespace DefaultValues
{
    class DefaultValues
    {
        static void Main()
        {
            Dictionary<string,string> dictionary = new Dictionary<string, string>();
            var intput = Console.ReadLine();
            while (intput!="end")
            {
                var inputParams = intput.Split(new[] {' ', '-', '>'}, StringSplitOptions.RemoveEmptyEntries);
                var key = inputParams[0];
                var value = inputParams[1];
               
                dictionary[key] = value;
                intput = Console.ReadLine();
            }

            intput = Console.ReadLine();
            var wordToReplace = intput;

            Dictionary<string,string> unchangeDictionary= dictionary
                .OrderByDescending(i => i.Value.Length)
                .Where(i => i.Value != "null")
                .ToDictionary(x => x.Key , x => x.Value);

            Dictionary<string, string> changeDictionary = dictionary
                .Where(i => i.Value == "null")
                .ToDictionary(x => x.Key, x => wordToReplace);

            foreach (var item in unchangeDictionary)
            {
                Console.WriteLine("{0} <-> {1}",item.Key,item.Value);
            }

            foreach (var item in changeDictionary)
            {
                Console.WriteLine("{0} <-> {1}", item.Key, item.Value);
            }
        }
    }
}
