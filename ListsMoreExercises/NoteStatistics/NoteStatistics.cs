using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class NoteStatistics
{
    public static void Main()
    {
        var freq = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
        var notes = new List<string>();
        var naturals = new List<string>();
        var sharps = new List<string>();
        var dic = new Dictionary<string, double>();
        dic.Add("C", 261.63);
        dic.Add("C#", 277.18);
        dic.Add("D", 293.66);
        dic.Add("D#",311.13);
        dic.Add("E", 329.63);
        dic.Add("F", 349.23);
        dic.Add("F#", 369.99);
        dic.Add("G", 392.00);
        dic.Add("G#", 415.30);
        dic.Add("A", 440.00);
        dic.Add("A#", 466.16);
        dic.Add("B", 493.88);
        for (int i = 0; i < freq.Count; i++)
        {
            var currentNum = freq[i];
            if (dic.ContainsValue(currentNum))
            {
                
            }
        }



    }
}

