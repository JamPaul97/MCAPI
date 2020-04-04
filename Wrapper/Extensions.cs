using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace MCAPIWrapper
{
    public static class Extensions
    {
        public static System.Drawing.Image FromURL(string url)
        {
            try
            {
                var request = WebRequest.Create(url);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    return System.Drawing.Bitmap.FromStream(stream);
                }
            }
            catch
            {
                return null;
            }
        }
        public static System.Drawing.Image FromBase64(this string data)
        {
            byte[] bytes = Convert.FromBase64String(data);
            using (MemoryStream ms = new MemoryStream(bytes))
                return System.Drawing.Image.FromStream(ms);
        }
        public static string ToBase64(this System.Drawing.Image img)
        {
            using (MemoryStream m = new MemoryStream())
            {
                img.Save(m, img.RawFormat);
                byte[] imageBytes = m.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }
        public static string ToString(this Primatives.UUID uuid)
        {
            string b = uuid.WithoutDashes;
            return b;
        }
    }
}
