using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindromes
{
    class Palindromes
    {
        public static void Main()
        {
            var elements = new[] {'.', ',', ' ', '?', '!'};
            var text = Console.ReadLine().Split(elements, StringSplitOptions.RemoveEmptyEntries).ToList();
            var result = new List<string>();
            foreach (var word in text)
            {
                var reversedWord = string.Join("", word.ToCharArray().Reverse());
                if (word==reversedWord)
                {
                    result.Add(word);
                }
            }
            Console.WriteLine(string.Join(", ",result.Distinct().OrderBy(w => w)));
        }
    }
}
