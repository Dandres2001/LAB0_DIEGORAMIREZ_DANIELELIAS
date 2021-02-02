using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB0_DIEGORAMIREZ_DANIELELIAS.Models.Data
{
    public sealed class Singleton
    {
        private readonly static Singleton _instance = new Singleton();
        public List<Client> ClientsList;

        private Singleton()
        {
            ClientsList = new List<Client>();
        }

        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
