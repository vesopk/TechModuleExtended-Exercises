using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecodeRadioFrequencies
{
    static void Main()
    {
        var frequences = Console.ReadLine().Split(' ').ToList();
        var result = new List<char>();

        for (int i = 0; i < frequences.Count; i++)
        {
            var frequence = frequences[i].Split('.').ToList();
            var firstFreq = int.Parse(frequence[0]);
            var secondFreq = int.Parse(frequence[1]);
            if (firstFreq!=0)
            {
                result.Insert(i, (char)firstFreq);
            }
            if (secondFreq!=0)
            {
                result.Insert(result.Count - i, (char)secondFreq);
            }
           
        }
        Console.WriteLine(string.Join("",result));
    }
}

