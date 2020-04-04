using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAPIWrapper.Primatives
{
    public class AccessToken
    {
        private string data;
        private UUID uuid;
        public UUID clientToken
        {
            get
            {
                return this.uuid;
            }
        }
        public AccessToken(string data)
        {
            this.data = data;
        }
        public AccessToken(string data,UUID clientToken)
        {
            this.data = data;
            this.uuid = clientToken;
        }
        public static implicit operator string(AccessToken token)
        {
            if(token == null)
                return string.Empty;
            return token.data;
        }
    }
}
