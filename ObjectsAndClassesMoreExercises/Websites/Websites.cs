using System;
using System.Collections.Generic;
using System.Linq;

namespace Websites
{
    class Websites
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var websites = new List<Website>();
            while (inputLine!="end")
            {
                var currentWebsite = Website.Parse(inputLine);
                websites.Add(currentWebsite);
                inputLine = Console.ReadLine();
            }
            foreach (var website in websites)
            {
                if (website.Queries == null) 
                {
                    Console.WriteLine($"https://www.{website.Host}.{website.Domain}");
                }
                else
                {
                    var queries = new List<string>();
                    foreach (var query in website.Queries)
                    {
                        queries.Add($"[{query}]");
                    }
                    Console.WriteLine($"https://www.{website.Host}.{website.Domain}/query?={string.Join("&",queries)}");
                }
            }
        }
    }
}

class Website
{
    public string Host { get; set; }
    public string Domain { get; set; }
    public List<string> Queries { get; set; }

    public static Website Parse(string inputLine)
    {
        var inputLineParams =
            inputLine.Split(new[] {'|'}, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();

        if (inputLineParams.Count >= 3)
        {
            var queries = inputLineParams[2].Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            return new Website()
            {
                Host = inputLineParams[0],
                Domain = inputLineParams[1],
                Queries = queries
            };
        }
        else
        {
            return new Website()
            {
                Host = inputLineParams[0],
                Domain = inputLineParams[1],
                Queries = null
            };
        }
    }
}
