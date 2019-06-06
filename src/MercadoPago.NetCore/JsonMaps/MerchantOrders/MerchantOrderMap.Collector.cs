using MercadoPago.NetCore.Model.Resources.Dataclassures.MerchantOrder;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using System;

namespace Moises.Toolkit.MercadoPago.NetCore.JsonMaps.MerchantOrders
{
    internal class CollectorMap : IJsonTypeConfiguration<Collector>
    {
        public void Configure(JsonTypeBuilder<Collector> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.Id).HasFieldName("id");
            jsonTypeBuilder.Property(x => x.Email).HasFieldName("email");
            jsonTypeBuilder.Property(x => x.NickName).HasFieldName("nickname");
        }
    }
}
