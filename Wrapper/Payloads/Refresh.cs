using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAPIWrapper.Payloads
{
    internal class Refresh
    {
        public string accessToken;
        public string clientToken;
        public bool requestUser = false;
    }
}
