using MercadoPago.NetCore.Model.Resources.Dataclassures.Preference;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using System;

namespace moisesToolkit.MercadoPago.NetCore.JsonMaps.Preferences
{
    internal class PayerMap : IJsonTypeConfiguration<Payer>
    {
        public void Configure(JsonTypeBuilder<Payer> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.Name).HasFieldName("name");
            jsonTypeBuilder.Property(x => x.Surname).HasFieldName("surname");
            jsonTypeBuilder.Property(x => x.Email).HasFieldName("email");
            jsonTypeBuilder.Property(x => x.Phone).HasFieldName("phone");
            jsonTypeBuilder.Property(x => x.Identification).HasFieldName("identification");
            jsonTypeBuilder.Property(x => x.Address).HasFieldName("address");
            jsonTypeBuilder.Property(x => x.DateCreated).HasFieldName("date_created");

        }
    }
}
