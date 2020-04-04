using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAPIWrapper.Primatives
{
    public class Cape
    {
        private string data;
        private UUID owner;
        public UUID Owner
        {
            get
            {
                return this.owner;
            }
        }
        public Cape(string urlSkin,UUID owner)
        {
            this.owner = owner;
            var img = Extensions.FromURL(urlSkin);
            this.data = img.ToBase64();
        }
        public static implicit operator System.Drawing.Image(Cape skin)
        {
            return skin.data.FromBase64();
        }
    }
}
