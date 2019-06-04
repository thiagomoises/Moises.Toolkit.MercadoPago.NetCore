using MercadoPago.NetCore.Model.Resources.Dataclassures.Preference;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using Newtonsoft.Json.Converters;
using System;

namespace moisesToolkit.MercadoPago.NetCore.JsonMaps.Preferences
{
    internal class ShipmentMap : IJsonTypeConfiguration<Shipment>
    {
        public void Configure(JsonTypeBuilder<Shipment> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.Mode).HasFieldName("mode")
                .HasConverter(new StringEnumConverter());
            jsonTypeBuilder.Property(x => x.LocalPickUp).HasFieldName("local_pick_up");
            jsonTypeBuilder.Property(x => x.Dimensions).HasFieldName("dimensions");
            jsonTypeBuilder.Property(x => x.DefaultShippingMethod).HasFieldName("default_shipping_method");
            jsonTypeBuilder.Property(x => x.FreeMethods).HasFieldName("free_methods");
            jsonTypeBuilder.Property(x => x.Cost).HasFieldName("cost");
            jsonTypeBuilder.Property(x => x.FreeShipping).HasFieldName("free_shipping");
            jsonTypeBuilder.Property(x => x.ReceiverAddress).HasFieldName("receiver_address");
        }
    }
}
