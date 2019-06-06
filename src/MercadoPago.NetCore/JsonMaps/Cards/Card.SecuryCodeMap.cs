
using MercadoPago.NetCore.Model.Resources.Dataclassures.Card;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;

namespace Moises.Toolkit.MercadoPago.NetCore.JsonMaps.Cards
{
    internal class SecuryCodeMap : IJsonTypeConfiguration<SecurityCode>
    {
        public void Configure(JsonTypeBuilder<SecurityCode> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.CardLocation)
                .HasFieldName("card_location");
            jsonTypeBuilder.Property(x => x.Length)
                .HasFieldName("length");
        }
    }
}
