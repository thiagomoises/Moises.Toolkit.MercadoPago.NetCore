using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MercadoPago.NetCore.Model.Resources.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderType
    {
        /// <summary> The order is from MercadoLibre </summary>
        MercadoLibre,
        /// <summary> It is a MercadoPago merchant_order </summary>
        MercadoPago

    }
}
