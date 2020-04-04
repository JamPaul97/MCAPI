using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Net;
using MCAPIWrapper.Enumurators;
using System.Web;
using System.IO;
using Newtonsoft.Json;
namespace MCAPIWrapper
{
    
    public static class Requester
    {
        
        public static class URL
        {
            public const string Status = "https://status.mojang.com/check";
        }

        internal static string Request(string url,NameValueCollection data = null,RequestType Method = RequestType.GET,string Accept = "application/json, text/javascript;q=0.9, */*;q=0.5",string ContentType = "application/x-www-form-urlencoded; charset=UTF-8",            string UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.57 Safari/537.36",int Timeout = 50000)
        {
            string dataString = string.Empty;
            if (data != null)
            {
                dataString = (data == null ? null : String.Join("&", Array.ConvertAll(data.AllKeys, key =>

                   string.Format("{0}={1}", WebUtility.UrlEncode(key), WebUtility.UrlEncode(data[key]))
           )));
            }

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = Method == RequestType.GET ? "GET" : "POST";
            request.Accept = Accept;
            request.ContentType = ContentType;
            request.UserAgent = UserAgent;
            request.Timeout = Timeout;
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            if (Method == RequestType.GET)
            {
                try
                {
                    var response = request.GetResponse() as HttpWebResponse;
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        return reader.ReadToEnd();
                    }
                }
                catch
                {
                    return string.Empty;
                }
            }
            else
            {
                try
                {
                    byte[] dataBytes = Encoding.UTF8.GetBytes(dataString);
                    request.ContentLength = dataBytes.Length;

                    using (Stream requestStream = request.GetRequestStream())
                    {
                        requestStream.Write(dataBytes, 0, dataBytes.Length);
                    }
                    var response = request.GetResponse() as HttpWebResponse;
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        return reader.ReadToEnd();
                    }
                }
                catch
                {
                    return string.Empty;
                }
            }
        }
        public static string RequestJson(string url, dynamic data = null, RequestType Method = RequestType.POST, string Accept = "application/json, text/javascript;q=0.9, */*;q=0.5", string ContentType = "application/json", string UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.57 Safari/537.36", int Timeout = 50000)
        {
            string dataString = string.Empty;
            dataString = Newtonsoft.Json.JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = Method == RequestType.GET ? "GET" : "POST";
            request.Accept = Accept;
            request.ContentType = ContentType;
            request.UserAgent = UserAgent;
            request.Timeout = Timeout;
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            if (Method == RequestType.GET)
            {
                try
                {
                    var response = request.GetResponse() as HttpWebResponse;
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        return reader.ReadToEnd();
                    }
                }
                catch
                {
                    return string.Empty;
                }
            }
            else
            {
                try
                {
                    byte[] dataBytes = Encoding.UTF8.GetBytes(dataString);
                    request.ContentLength = dataBytes.Length;

                    using (Stream requestStream = request.GetRequestStream())
                    {
                        requestStream.Write(dataBytes, 0, dataBytes.Length);
                    }
                    var response = request.GetResponse() as HttpWebResponse;
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        return reader.ReadToEnd();
                    }
                }
                catch(Exception ex)
                {
                    return null;
                }
            }
        }
    }
}
