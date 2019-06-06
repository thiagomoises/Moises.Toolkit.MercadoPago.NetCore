
using MercadoPago.NetCore.Model.Resources.Dataclassures.Card;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using Newtonsoft.Json.Converters;

namespace Moises.Toolkit.MercadoPago.NetCore.JsonMaps.Cards
{
    internal class IdentificationMap : IJsonTypeConfiguration<Identification>
    {
        public void Configure(JsonTypeBuilder<Identification> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.Number)
                .HasFieldName("number");

            jsonTypeBuilder.Property(x => x.Subtype)
                .HasFieldName("subtype");

            jsonTypeBuilder.Property(x => x.Type)
                .HasFieldName("type");
        }
    }
}
