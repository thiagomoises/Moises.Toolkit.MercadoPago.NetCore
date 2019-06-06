
using MercadoPago.NetCore.Model.Resources.Dataclassures.Card;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using Newtonsoft.Json.Converters;

namespace Moises.Toolkit.MercadoPago.NetCore.JsonMaps.Cards
{
    internal class HolderCardMap : IJsonTypeConfiguration<CardHolder>
    {
        public void Configure(JsonTypeBuilder<CardHolder> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.Name)
                .HasFieldName("name");

            jsonTypeBuilder.Property(x => x.Identification)
                .HasFieldName("identification");
        }
    }
}
