using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MercadoPago.NetCore.Model.Resources.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EntityType
    {
        ///<summary>Payer is individual</summary>
        individual,
        ///<summary>Payer is an association</summary>
        association

    }
}
