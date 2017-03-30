using System;
using System.Collections.Generic;

namespace SocialMediaPosts
{
    class SocialMediaPosts
    {
        static void Main()
        {
            var inputData = Console.ReadLine();
            Dictionary<string,Dictionary<string,List<string>>> socialMedia = new Dictionary<string, Dictionary<string, List<string>>>();
            while (inputData!="drop the media")
            {
                var inputDataParams = inputData.Split(new []{ ' ' },StringSplitOptions.RemoveEmptyEntries);
                var command = inputDataParams[0];
                var postName = inputDataParams[1];
                if (command=="post")
                {
                    if (!socialMedia.ContainsKey(postName))
                    {
                        socialMedia[postName] = new Dictionary<string, List<string>>();
                    }
                }
                else if (command=="like")
                {
                    if (!socialMedia[postName].ContainsKey("Like"))
                    {
                        socialMedia[postName]["Like"] = new List<string>();
                    }
                    socialMedia[postName]["Like"].Add(command);
                }
                else if (command=="dislike")
                {
                    if (!socialMedia[postName].ContainsKey("Dislike"))
                    {
                        socialMedia[postName]["Dislike"] = new List<string>();
                    }
                    socialMedia[postName]["Dislike"].Add(command);
                }
                else if (command=="comment")
                {
                    var writer = inputDataParams[2];
                    int length = command.Length + postName.Length + writer.Length + 3;
                    var comment = inputData.Substring(length);
                    if (!socialMedia[postName].ContainsKey(writer))
                    {
                        socialMedia[postName][writer] = new List<string>();
                    }
                    socialMedia[postName][writer].Add(comment);
                }
                inputData = Console.ReadLine();
            }
            foreach (var post in socialMedia)
            {
                var likes = 0;
                var dislikes = 0;
                var writers = post.Value;
                foreach (var item in post.Value)
                {
                    if (item.Key == "Like")
                    {
                        likes = item.Value.Count;
                    }
                    else if (item.Key == "Dislike")
                    {
                        dislikes = item.Value.Count;
                    }
                }
                Console.WriteLine($"Post: {post.Key} | Likes: {likes} | Dislikes: {dislikes}");
                Console.WriteLine("Comments:");

                var noComment = true;
                foreach (var comment in writers)
                {
                    if (comment.Key != "Like" && comment.Key != "Dislike")
                    {
                        noComment = false;
                        foreach (var com in comment.Value)
                        {
                            Console.WriteLine($"*  {comment.Key}: {com}");
                        }
                    }
                }

                if (noComment)
                {
                    Console.WriteLine("None");
                }
            }

        }
    }
}
