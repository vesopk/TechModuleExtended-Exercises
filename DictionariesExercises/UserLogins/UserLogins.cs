using System;
using System.Collections.Generic;
using System.Linq;

namespace UserLogins
{
    class UserLogins
    {
        public static void Main()
        {
            var usersAndPasswords = new Dictionary<string, string>();
            var count = 0;
            var hasPassedLogin = false;
            while (true)
            {
                var input = Console.ReadLine().Split(new[] {' ', '-', '>'}, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (input[0] == "end")
                {
                    Console.WriteLine($"unsuccessful login attempts: {count}");
                    break;
                }
                
                while ((input[0] != "login") && (!hasPassedLogin))
                {
                    var user = input[0];
                    var pass = input[1];
                    if (!usersAndPasswords.ContainsKey(user))
                    {
                        usersAndPasswords.Add(user, pass);
                    }
                    else
                    {
                        usersAndPasswords[user] = pass;
                    }
                    input = Console.ReadLine().Split(new[] {' ', '-', '>'}, StringSplitOptions.RemoveEmptyEntries).ToList();
                }
                if (input[0] == "login")
                {
                    hasPassedLogin = true;
                }

                if (input[0] == "login") continue;
                var username = input[0];
                var password = input[1];

                if (usersAndPasswords.ContainsKey(username))
                {
                    if (usersAndPasswords[username] == password)
                    {
                        Console.WriteLine($"{username}: logged in successfully");
                    }
                    else
                    {
                        Console.WriteLine($"{username}: login failed");
                        count++;
                    }
                }
                else
                {
                    Console.WriteLine($"{username}: login failed");
                    count++;
                }
            }
        }
    }
}

