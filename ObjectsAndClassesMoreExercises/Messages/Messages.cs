using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    class Messages
    {
        public static void Main()
        {
            var users = new List<User>();
            var inputLine = Console.ReadLine();
            while (inputLine!="exit")
            {
                inputLine = Console.ReadLine();
            }
        }
    }
}

class User
{
    public string Username { get; set; }
    public List<Message> ReceivedMessages { get; set; }
}

class Message
{
    public string Content { get; set; }
    public User Sender { get; set; }
}