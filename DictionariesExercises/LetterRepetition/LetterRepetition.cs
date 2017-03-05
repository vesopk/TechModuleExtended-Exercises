using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterRepetition
{
    class LetterRepetition
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var textTokens = text.ToCharArray();
            var tokensAndCount = new Dictionary<char,int>();

            foreach (var currentChar in textTokens)
            {
                if (tokensAndCount.ContainsKey(currentChar))
                {
                    tokensAndCount[currentChar] += 1;
                }
                else
                {
                    tokensAndCount.Add(currentChar,1);
                }
            }
            foreach (var item in tokensAndCount)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
