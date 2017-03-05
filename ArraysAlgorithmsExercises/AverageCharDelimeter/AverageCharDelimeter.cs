using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AverageCharDelimeter
{
    public static void Main()
    {
        var input = Console.ReadLine();
        var text = input.Split(' ').ToList();
        var list = new List<char>();
        var sum = 0;
        for (var i = 0; i < text.Count; i++)
        {
            var currentChars = text[i].ToCharArray();
            list.AddRange(currentChars);
        }
        for (var i = 0; i < list.Count; i++)
        {
            var charArr = list[i];
            sum = sum + charArr;
        }
        var specialSymbol = sum / list.Count;
        var result = "";
        for (int i = 0; i < list.Count; i++)
        {
            
            var symbol = (char) (specialSymbol);
            var output = symbol.ToString().ToUpper();
            result = input.Replace(" ",output);
        }
        Console.WriteLine(string.Join("",result));
    }
}

