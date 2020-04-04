using System.Collections.Generic;
using System.Linq;
using MCAPIWrapper.Enumurators;
namespace MCAPIWrapper
{
    /// <summary>
    /// Get Minecraft's API Status
    /// An enumurator is returner for each service.
    /// </summary>
    public static class Status
    {
        /// <summary>
        /// Minecraft.net Status
        /// </summary>
        /// <returns>APIStatus Enumurator</returns>
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
        /// <summary>
        /// Session.minecraft.net Status
        /// </summary>
        /// <returns>APIStatus Enumurator</returns>
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
        /// <summary>
        /// account.mojang.com
        /// </summary>
        /// <returns>APIStatus Enumurator</returns>
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
        /// <summary>
        /// auth.mojang.com
        /// </summary>
        /// <returns>APIStatus Enumurator</returns>
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
        /// <summary>
        /// skins.minecraft.net status
        /// </summary>
        /// <returns>APIStatus Enumurator</returns>
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
        /// <summary>
        /// authserver.mojang.com
        /// </summary>
        /// <returns>APIStatus Enumurator</returns>
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
        /// <summary>
        /// sessionserver.mojang.com
        /// </summary>
        /// <returns>APIStatus Enumurator</returns>
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
        /// <summary>
        /// api.mojang.com status
        /// </summary>
        /// <returns>APIStatus Enumurator</returns>
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
        /// <summary>
        /// textures.minecraft.net
        /// </summary>
        /// <returns>APIStatus Enumurator</returns>
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
        /// <summary>
        /// mojang.com status
        /// </summary>
        /// <returns>APIStatus Enumurator</returns>
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
