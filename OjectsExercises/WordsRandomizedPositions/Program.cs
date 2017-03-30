using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsRandomizedPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Random rnd = new Random();

            for (int first = 0; first < words.Length; first++)
            {
                int second = rnd.Next(0, words.Length);
                string old = words[first];
                words[first] = words[second];
                words[second] = old;
            }
            Console.WriteLine(string.Join(" ",words));
        }
    }
}
