using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCAPIWrapper.Enumurators;
namespace MCAPIWrapper
{
    public static class Status
    {
        public static APIStatus MinecraftNET()
        {
            var response = Requester.Request(Requester.URL.Status);
            if (response == string.Empty)
                return APIStatus.Offline;
            var re = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(response);
            if (re.Where(x => x.ContainsKey("minecraft.net")).Single()["minecraft.net"] == "green")
                return APIStatus.Online;
            else if (re.Where(x => x.ContainsKey("minecraft.net")).Single()["minecraft.net"] == "yellow")
                return APIStatus.Issues;
            else return APIStatus.Offline;
        }
        public static APIStatus MinecraftSession()
        {
            var response = Requester.Request(Requester.URL.Status);
            if (response == string.Empty)
                return APIStatus.Offline;
            var re = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(response);
            if (re.Where(x => x.ContainsKey("session.minecraft.net")).Single()["session.minecraft.net"] == "green")
                return APIStatus.Online;
            else if (re.Where(x => x.ContainsKey("session.minecraft.net")).Single()["session.minecraft.net"] == "yellow")
                return APIStatus.Issues;
            else return APIStatus.Offline;
        }
        public static APIStatus MojangAccount()
        {
            var response = Requester.Request(Requester.URL.Status);
            if (response == string.Empty)
                return APIStatus.Offline;
            var re = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(response);
            if (re.Where(x => x.ContainsKey("account.mojang.com")).Single()["account.mojang.com"] == "green")
                return APIStatus.Online;
            else if (re.Where(x => x.ContainsKey("account.mojang.com")).Single()["account.mojang.com"] == "yellow")
                return APIStatus.Issues;
            else return APIStatus.Offline;
        }
        public static APIStatus MojangAuth()
        {
            var response = Requester.Request(Requester.URL.Status);
            if (response == string.Empty)
                return APIStatus.Offline;
            var re = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(response);
            if (re.Where(x => x.ContainsKey("auth.mojang.com")).Single()["auth.mojang.com"] == "green")
                return APIStatus.Online;
            else if (re.Where(x => x.ContainsKey("auth.mojang.com")).Single()["auth.mojang.com"] == "yellow")
                return APIStatus.Issues;
            else return APIStatus.Offline;
        }
        public static APIStatus MinecraftSkins()
        {
            var response = Requester.Request(Requester.URL.Status);
            if (response == string.Empty)
                return APIStatus.Offline;
            var re = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(response);
            if (re.Where(x => x.ContainsKey("skins.minecraft.net")).Single()["skins.minecraft.net"] == "green")
                return APIStatus.Online;
            else if (re.Where(x => x.ContainsKey("skins.minecraft.net")).Single()["skins.minecraft.net"] == "yellow")
                return APIStatus.Issues;
            else return APIStatus.Offline;
        }
        public static APIStatus MojangAuthServer()
        {
            var response = Requester.Request(Requester.URL.Status);
            if (response == string.Empty)
                return APIStatus.Offline;
            var re = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(response);
            if (re.Where(x => x.ContainsKey("authserver.mojang.com")).Single()["authserver.mojang.com"] == "green")
                return APIStatus.Online;
            else if (re.Where(x => x.ContainsKey("authserver.mojang.com")).Single()["authserver.mojang.com"] == "yellow")
                return APIStatus.Issues;
            else return APIStatus.Offline;
        }
        public static APIStatus MojangSessionServer()
        {
            var response = Requester.Request(Requester.URL.Status);
            if (response == string.Empty)
                return APIStatus.Offline;
            var re = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(response);
            if (re.Where(x => x.ContainsKey("sessionserver.mojang.com")).Single()["sessionserver.mojang.com"] == "green")
                return APIStatus.Online;
            else if (re.Where(x => x.ContainsKey("sessionserver.mojang.com")).Single()["sessionserver.mojang.com"] == "yellow")
                return APIStatus.Issues;
            else return APIStatus.Offline;
        }
        public static APIStatus MojangAPI()
        {
            var response = Requester.Request(Requester.URL.Status);
            if (response == string.Empty)
                return APIStatus.Offline;
            var re = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(response);
            if (re.Where(x => x.ContainsKey("api.mojang.com")).Single()["api.mojang.com"] == "green")
                return APIStatus.Online;
            else if (re.Where(x => x.ContainsKey("api.mojang.com")).Single()["api.mojang.com"] == "yellow")
                return APIStatus.Issues;
            else return APIStatus.Offline;
        }
        public static APIStatus MinecraftTextures()
        {
            var response = Requester.Request(Requester.URL.Status);
            if (response == string.Empty)
                return APIStatus.Offline;
            var re = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(response);
            if (re.Where(x => x.ContainsKey("textures.minecraft.net")).Single()["textures.minecraft.net"] == "green")
                return APIStatus.Online;
            else if (re.Where(x => x.ContainsKey("textures.minecraft.net")).Single()["textures.minecraft.net"] == "yellow")
                return APIStatus.Issues;
            else return APIStatus.Offline;
        }
        public static APIStatus Mojang()
        {
            var response = Requester.Request(Requester.URL.Status);
            if (response == string.Empty)
                return APIStatus.Offline;
            var re = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(response);
            if (re.Where(x => x.ContainsKey("mojang.com")).Single()["mojang.com"] == "green")
                return APIStatus.Online;
            else if (re.Where(x => x.ContainsKey("mojang.com")).Single()["mojang.com"] == "yellow")
                return APIStatus.Issues;
            else return APIStatus.Offline;
        }
    }
}
