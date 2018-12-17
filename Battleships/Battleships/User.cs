using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    public class User
    {
        private string name;

        public User()
        {
            Random rand = new Random();
            int _number = rand.Next();
            name = "Player_" + _number;
        }

        public User(string _name)
        {
            name = _name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SendMessage(string _message)
        {
            ChatRoom.ShowMessage(this, _message);
        }
    }
}
