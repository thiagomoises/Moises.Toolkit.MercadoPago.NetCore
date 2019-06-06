
using MercadoPago.NetCore.Model.Resources.Dataclassures.PaymentMethod;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using Newtonsoft.Json.Converters;

namespace Moises.Toolkit.MercadoPago.NetCore.JsonMaps.PaymentMethods
{
    internal class SecuryCodeMap : IJsonTypeConfiguration<SecurityCode>
    {
        public void Configure(JsonTypeBuilder<SecurityCode> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.CardLocation)
                .HasFieldName("card_location")
                .HasConverter(new StringEnumConverter());

            jsonTypeBuilder.Property(x => x.Mode)
                .HasFieldName("mode")
                .HasConverter(new StringEnumConverter());

            jsonTypeBuilder.Property(x => x.Length)
                .HasFieldName("length");
        }
    }
}
