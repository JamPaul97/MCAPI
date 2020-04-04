using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAPIWrapper
{
    public static class Authenticate
    {
        public static bool TryAuthenticate(string username, string password, out Primatives.AccessToken token, Primatives.UUID uuid = null,bool requestuser = false)
        {
            
            Payloads.Authenticate payload = new Payloads.Authenticate()
            {
                username = username,
                password = password,
                clientToken = uuid == null ? new Primatives.UUID() : uuid,
                requestUser = requestuser
            };
            var response = Requester.RequestJson("https://authserver.mojang.com/authenticate", payload);
            if(response == null)
            {
                token = null;
                return false;
            }
            else
            {
                JSONBases.Authenticate re = Newtonsoft.Json.JsonConvert.DeserializeObject<JSONBases.Authenticate>(response);
                token = new Primatives.AccessToken(re.accessToken, payload.clientToken);
                return true;
            }
        }
        public static bool TryRefresh(Primatives.AccessToken accessToken, out Primatives.AccessToken token, Primatives.UUID clientToken = null,bool requestUser = false)
        {
            Payloads.Refresh payload = new Payloads.Refresh()
            {
                accessToken = accessToken,
                clientToken = clientToken == null ? accessToken.clientToken == null? null : accessToken.clientToken :clientToken ,
                requestUser = requestUser
            };
            var response = Requester.RequestJson("https://authserver.mojang.com/refresh", payload);
            if (response == null)
            {
                token = null;
                return false;
            }
            else
            {
                JSONBases.Authenticate re = Newtonsoft.Json.JsonConvert.DeserializeObject<JSONBases.Authenticate>(response);
                token = new Primatives.AccessToken(re.accessToken, accessToken.clientToken);
                return true;
            }
        }
        public static bool Validate(Primatives.AccessToken accessToken)
        {
            Payloads.Refresh payload = new Payloads.Refresh()
            {
                accessToken = accessToken,
                clientToken = accessToken.clientToken,
                requestUser = false
            };
            var response = Requester.RequestJson("https://authserver.mojang.com/validate", payload);
            if (response == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Singout(string username, string password)
        {
            Payloads.Singout payload = new Payloads.Singout()
            {
                password = password,
                username = username
            };
            var response = Requester.RequestJson("https://authserver.mojang.com/signout", payload);
            if (response == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Invalidate(Primatives.AccessToken accessToken)
        {
            Payloads.Refresh payload = new Payloads.Refresh()
            {
                accessToken = accessToken,
                clientToken = accessToken.clientToken,
                requestUser = false
            };
            var response = Requester.RequestJson("https://authserver.mojang.com/invalidate", payload);
            if (response == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
