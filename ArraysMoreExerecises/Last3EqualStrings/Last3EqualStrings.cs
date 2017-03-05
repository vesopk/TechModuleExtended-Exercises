using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Last3EqualStrings
{
    public static void Main()
    {
        var words = Console.ReadLine().Split(' ').ToArray();
        var tempWords = new string[words.Length];
        var result = new List<string>();
        tempWords = words.Reverse().ToArray();
        for (int i = 0; i < words.Length; i++)
        {
            if (result.Count==3)
            {
                break;
            }
            else
            {
                var currentWord = tempWords[i];
                var nextWord = tempWords[i + 1];
                if (i>0)
                {
                    if (currentWord == nextWord || currentWord == tempWords[i - 1])
                    {
                        result.Add(currentWord);
                    }
                }
                else
                {
                    if (currentWord == nextWord)
                    {
                        result.Add(currentWord);
                    }
                }
            }
        }
        Console.WriteLine(string.Join(" ",result));
    }
}

