using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ArrayHistogram
{
    public static void Main()
    {
        var words = Console.ReadLine().Split(' ').ToList();
        var dic = new Dictionary<string,int>();
        foreach (var word in words)
        {
            if (dic.ContainsKey(word))
            {
                dic[word] = dic[word]+1;
            }
            else
            {
                dic.Add(word,1);
            }
        }
        var sum = 0;
        foreach (var count in dic.Values)
        {
            sum = sum + count;
        }
        var sortedDict = from entry in dic orderby entry.Value descending select entry;
        foreach (var word in sortedDict)
        {
            double sumFinal = sum;
            double wordValue = word.Value;
            double result = wordValue / sumFinal * 100;
            Console.WriteLine($"{word.Key} -> {word.Value} times ({result:F2}%)");
        }

    }
}

