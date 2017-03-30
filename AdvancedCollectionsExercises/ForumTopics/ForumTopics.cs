using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumTopics
{
    class ForumTopics
    {
        public static void Main()
        {
            var intputData = Console.ReadLine();
            Dictionary<string,HashSet<string>> dictionary = new Dictionary<string, HashSet<string>>();
            while (intputData!="filter")
            {
                var inputDataParams =
                    intputData.Split(new[] {' ', '-', '>', ','}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var topic = inputDataParams[0];
                if (!dictionary.ContainsKey(topic))
                {
                    dictionary[topic] = new HashSet<string>();
                }
                for (int i = 1; i < inputDataParams.Length; i++)
                {
                    var currentTag = inputDataParams[i];
                    dictionary[topic].Add(currentTag);
                }
                intputData = Console.ReadLine();
            }
            intputData = Console.ReadLine();
            var filters = intputData.Split(new[] {',',' '}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var topic in dictionary)
            {
                var isContained = true;
                foreach (var filter in filters)
                {
                    if (!topic.Value.Contains(filter))
                    {
                        isContained = false;
                    }
                }
                if (!isContained) continue;
                var secondArray = topic.Value.ToList();
                var tags = new List<string>();
                foreach (var tag in secondArray)
                {
                    var currentTag = $"#{tag}";
                    tags.Add(currentTag);
                }
                Console.WriteLine($"{topic.Key} | {string.Join(", ", tags)}");
            }
            
        }
    }
}
