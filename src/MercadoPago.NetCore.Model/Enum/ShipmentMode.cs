using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MercadoPago.NetCore.Model.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShipmentMode
    {
        ///<summary>Custom shipping</summary>
        Custom,
        ///<summary>MercadoEnvíos</summary>
        Me2, 
        ///<summary>Shipping mode not specified</summary>
        NotSpecified
    }
}
