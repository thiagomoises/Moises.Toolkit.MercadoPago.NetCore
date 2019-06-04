﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel;

namespace MercadoPago.NetCore.Model.Resources.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EncodingType
    { 
        /// <summary> Encodes data using the Code 128 symbology </summary>
        [Description("UCC/EAN 128")]
        UCC_EAN_128,
        /// <summary> High-density alphanumeric code </summary>
        Code128C,
        /// <summary> Media density code </summary>
        Code39
    }
}
