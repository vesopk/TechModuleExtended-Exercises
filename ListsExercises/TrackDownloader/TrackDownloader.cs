using System;
using System.Collections.Generic;
class TrackDownloader
{
    public static void Main()
    {
        var blackList = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var result = new List<string>();
        while (true)
        {
            var song = Console.ReadLine();
            var songsTokens = song.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (songsTokens[0] == "end")
            {
                break;
            }

            var isNotContained = true;
            for (int j = 0; j < blackList.Length; j++)
            {
                if (song.Contains(blackList[j]))
                {
                    isNotContained = false;
                }
            }
            if (isNotContained)
            {
                result.Add(song);
            }
        }

        result.Sort();
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}

