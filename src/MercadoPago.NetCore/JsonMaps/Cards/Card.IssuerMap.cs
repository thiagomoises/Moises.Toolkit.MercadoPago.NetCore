
using MercadoPago.NetCore.Model.Resources.Dataclassures.Card;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using Newtonsoft.Json.Converters;

namespace Moises.Toolkit.MercadoPago.NetCore.JsonMaps.Cards
{
    internal class IssuerMap : IJsonTypeConfiguration<Issuer>
    {
        public void Configure(JsonTypeBuilder<Issuer> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.Id)
                .HasFieldName("id");
            jsonTypeBuilder.Property(x => x.Name)
                .HasFieldName("name");
        }
    }
}
