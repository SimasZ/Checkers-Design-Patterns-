using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Checkers
{
    public sealed class Singleton
    {
        public string name;
        public IPAddress ipAdress;
        private static readonly Singleton INSTANCE = new Singleton();


        private Singleton()
        {
            this.name = "";
            this.ipAdress = null;
        }
        
        public static Singleton Instance
        {
            get
            {
                return INSTANCE;
            }
        }
        
    }
}
