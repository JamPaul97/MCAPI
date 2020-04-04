using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAPIWrapper.JSONBases
{
    internal class Status
    {
        [Newtonsoft.Json.JsonProperty("minecraft.net")]
        public string minecraftnet;
        [Newtonsoft.Json.JsonProperty("session.minecraft.net")]
        public string minecraftsession;
        [Newtonsoft.Json.JsonProperty("account.mojang.com")]
        public string mojangaccount;
        [Newtonsoft.Json.JsonProperty("auth.mojang.com")]
        public string mojangauth;
        [Newtonsoft.Json.JsonProperty("skins.minecraft.net")]
        public string minecraftskins;
        [Newtonsoft.Json.JsonProperty("authserver.mojang.com")]
        public string mojangauthserver;
        [Newtonsoft.Json.JsonProperty("sessionserver.mojang.com")]
        public string mojangsessionserver;
        [Newtonsoft.Json.JsonProperty("api.mojang.com")]
        public string mojangapi;
        [Newtonsoft.Json.JsonProperty("textures.minecraft.net")]
        public string minecrafttextures;
        [Newtonsoft.Json.JsonProperty("mojang.com")]
        public string mojang;

    }
}
