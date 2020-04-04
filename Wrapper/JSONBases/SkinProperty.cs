using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAPIWrapper.JSONBases
{
    internal class SkinProperty
    {
        public long timestamp;
        public string profileId;
        public string profileName;
        public Dictionary<string,_url> textures;
        public class _url
        {
            public string url;
        }
    }
}
