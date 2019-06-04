using MercadoPago.NetCore.Model.Resources.Dataclassures.Preference;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using System;

namespace moisesToolkit.MercadoPago.NetCore.JsonMaps.Preferences
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
