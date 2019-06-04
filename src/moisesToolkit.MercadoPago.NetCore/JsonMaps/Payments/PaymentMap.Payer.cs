using MercadoPago.NetCore.Model.Resources.Dataclassures.Payment;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using System;

namespace moisesToolkit.MercadoPago.NetCore.JsonMaps.Payments
{
    internal class PayerMap : IJsonTypeConfiguration<Payer>
    {
        public void Configure(JsonTypeBuilder<Payer> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.Id).HasFieldName("id");
            jsonTypeBuilder.Property(x => x.Email).HasFieldName("email");
            jsonTypeBuilder.Property(x => x.Identification).HasFieldName("identification");
            jsonTypeBuilder.Property(x => x.Phone).HasFieldName("phone");
            jsonTypeBuilder.Property(x => x.FirstName).HasFieldName("first_name");
            jsonTypeBuilder.Property(x => x.LastName).HasFieldName("last_name");
            jsonTypeBuilder.Property(x => x.Entity_type).HasFieldName("entity_type");

        }
    }
}
