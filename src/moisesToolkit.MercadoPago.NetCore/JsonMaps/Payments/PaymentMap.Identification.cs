using MercadoPago.NetCore.Model.Resources.Dataclassures.Payment;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using System;

namespace moisesToolkit.MercadoPago.NetCore.JsonMaps.Payments
{
    internal class IdentificationMap : IJsonTypeConfiguration<Identification>
    {
        public void Configure(JsonTypeBuilder<Identification> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.Type).HasFieldName("type");
            jsonTypeBuilder.Property(x => x.Number).HasFieldName("number");
        }
    }
}
