using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace MCAPIWrapper.Primatives
{
    [JsonConverter(typeof(ToStringJsonConverter))]
    public class UUID
    {
        private string data;
        public string WithoutDashes
        {
            get
            {
                return this.data;
            }
        }
        public string WithDashes
        {
            get
            {
                return Guid.Parse(this.data).ToString();
            }
        }
        public UUID(string uuid)
        {
            this.data = uuid.Replace("-","");
        }
        public UUID()
        {
            this.data = Guid.NewGuid().ToString().Replace("-","");
        }
        public static implicit operator string(UUID uuid)
        {
            if (uuid == null)
                return string.Empty;
            return uuid.data;
        }
        
    }
    internal class ToStringJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(Extensions.ToString((UUID)value));
        }

        public override bool CanRead
        {
            get { return false; }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
