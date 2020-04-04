using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAPIWrapper.JSONBases
{
    internal class SkinCape
    {
        public string id;
        public string name;
        public List<_data> properties;
        public class _data
        {
            public string name;
            public string value;
        }
    }
}
