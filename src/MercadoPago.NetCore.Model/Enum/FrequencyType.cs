using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MercadoPago.NetCore.Model.Resources.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FrequencyType
    {
        
        days,
        
        months
    }
}
