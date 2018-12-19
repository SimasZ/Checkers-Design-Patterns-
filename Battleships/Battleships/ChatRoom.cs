using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    public class ChatRoom
    {
        public static void ShowMessage(User _user, string _message)
        {
            string _line = DateTime.Today.ToShortTimeString() + " " + _user.GetName() + " said: " + _message;
            Console.WriteLine(_line);
        }
    }
}
