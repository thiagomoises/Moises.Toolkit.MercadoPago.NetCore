using MercadoPago.NetCore.Model.Resources.Dataclassures.MerchantOrder;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using Newtonsoft.Json.Converters;
using System;

namespace moisesToolkit.MercadoPago.NetCore.JsonMaps.MerchantOrders
{
    internal class ShipmentMap : IJsonTypeConfiguration<Shipment>
    {
        public void Configure(JsonTypeBuilder<Shipment> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.Id).HasFieldName("id");
            jsonTypeBuilder.Property(x => x.ShipmentType).HasFieldName("shipment_type");
            jsonTypeBuilder.Property(x => x.ShipmentMode).HasFieldName("shipping_mode");
            jsonTypeBuilder.Property(x => x.PickingType).HasFieldName("picking_type");
            jsonTypeBuilder.Property(x => x.Status).HasFieldName("status");
            jsonTypeBuilder.Property(x => x.Substatus).HasFieldName("substatus");
            jsonTypeBuilder.Property(x => x.Items).HasFieldName("items");
            jsonTypeBuilder.Property(x => x.DateCreated).HasFieldName("date_created");
            jsonTypeBuilder.Property(x => x.LastModified).HasFieldName("last_modified");
            jsonTypeBuilder.Property(x => x.DateFirstPrinted).HasFieldName("date_first_printed");
            jsonTypeBuilder.Property(x => x.ServiceId).HasFieldName("service_id");
            jsonTypeBuilder.Property(x => x.SenderId).HasFieldName("sender_id");
            jsonTypeBuilder.Property(x => x.ReceiverId).HasFieldName("receiver_id");
            jsonTypeBuilder.Property(x => x.Address).HasFieldName("receiver_address");
            }
    }
}
