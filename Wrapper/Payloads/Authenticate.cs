using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAPIWrapper.Payloads
{
    internal class Authenticate
    {
        public string username;
        public string password;
        public MCAPIWrapper.Primatives.UUID clientToken;
        public bool requestUser = true;
        public _agent agent = new _agent();
        public class _agent
        {
            public string name = "Minecraft";
            public int version = 1;
        }
    }
}
