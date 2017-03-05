using System;
using System.Collections.Generic;
using System.Linq;

class OddOccurrences
{
    public static void Main()
    {
        var words = Console.ReadLine().ToLower().Split(' ').ToList();
        var wordsCount = new Dictionary<string,int>();
        foreach (var word in words)
        {
            if (!wordsCount.ContainsKey(word))
            {
                wordsCount.Add(word, 1);
            }
            else
            {
                wordsCount[word] += 1;
            }
        }
        var result = (from wordAndCount in wordsCount where wordAndCount.Value % 2 != 0 select wordAndCount.Key).ToList();
        Console.WriteLine(string.Join(", ",result));
    }
}

