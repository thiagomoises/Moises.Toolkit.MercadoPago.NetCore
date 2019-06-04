using MercadoPago.NetCore.Model.Resources.Dataclassures.MerchantOrder;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using System;

namespace moisesToolkit.MercadoPago.NetCore.JsonMaps.MerchantOrders
{
    internal class PayerMap : IJsonTypeConfiguration<Payer>
    {
        public void Configure(JsonTypeBuilder<Payer> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.Id).HasFieldName("id");
            jsonTypeBuilder.Property(x => x.Email).HasFieldName("email");
            jsonTypeBuilder.Property(x => x.NickName).HasFieldName("nickname");

        }
    }
}
