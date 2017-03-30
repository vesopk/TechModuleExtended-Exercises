using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWords
{
    class RandomizeWords
    {
        static void Main()
        {
            var words = Console.ReadLine().Split(' ').ToList();
            Random rnd = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                var currentWord = words[i];
                var randomPosition = rnd.Next(0, words.Count);

                var tempWord = words[randomPosition];
                words[randomPosition] = currentWord;
                words[i] = tempWord;
            }
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
