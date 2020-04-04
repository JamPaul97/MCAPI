using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCAPIWrapper.Primatives;
using System.ComponentModel;
namespace MCAPIWrapper
{
    public static class API
    {
        public static bool TryGetUUIDByUsername(string username,out UUID uuid)
        {
            string response = Requester.Request(string.Format("https://api.mojang.com/users/profiles/minecraft/{0}", username));
            if (response == string.Empty)
            { uuid = null; return false; }
            else
            {
                JSONBases.UUIDByUsername re = Newtonsoft.Json.JsonConvert.DeserializeObject<JSONBases.UUIDByUsername>(response);
                uuid = new UUID(re.id);
                return true;
            }

        }
        public static bool TryGetSkin(UUID uuid, out Skin skin)
        {
            var response = Requester.Request("https://sessionserver.mojang.com/session/minecraft/profile/" + uuid);
            if (response == string.Empty)
            {
                skin = null;
                return false;
            }
            else
            {
                var re = Newtonsoft.Json.JsonConvert.DeserializeObject<JSONBases.SkinCape>(response);
                if(re.properties.Count <= 0)
                {
                    skin = null;
                    return false;
                }
                string data = re.properties[0].value;
                data = Encoding.UTF8.GetString(Convert.FromBase64String(data));
                var ree = Newtonsoft.Json.JsonConvert.DeserializeObject<JSONBases.SkinProperty>(data);
                if(ree.textures.ContainsKey("SKIN"))
                {
                    string url = ree.textures["SKIN"].url;
                    skin = new Skin(url, uuid);
                    return true;
                }
                else
                {
                    skin = null;
                    return false;
                }
                
                skin = null;
                return true;
            }
        }
        public static bool TryGetCape(UUID uuid, out Cape cape)
        {
            var response = Requester.Request("https://sessionserver.mojang.com/session/minecraft/profile/" + uuid);
            if (response == string.Empty)
            {
                cape = null;
                return false;
            }
            else
            {
                var re = Newtonsoft.Json.JsonConvert.DeserializeObject<JSONBases.SkinCape>(response);
                if (re.properties.Count <= 0)
                {
                    cape = null;
                    return false;
                }
                string data = re.properties[0].value;
                data = Encoding.UTF8.GetString(Convert.FromBase64String(data));
                var ree = Newtonsoft.Json.JsonConvert.DeserializeObject<JSONBases.SkinProperty>(data);
                if (ree.textures.ContainsKey("CAPE"))
                {
                    string url = ree.textures["CAPE"].url;
                    cape = new Cape(url, uuid);
                    return true;
                }
                else
                {
                    cape = null;
                    return false;
                }
            }
        }
    }
}
