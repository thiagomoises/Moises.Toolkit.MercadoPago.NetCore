
using MercadoPago.NetCore.Model.Resources.Dataclassures.PaymentMethod;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using Newtonsoft.Json.Converters;

namespace moisesToolkit.MercadoPago.NetCore.JsonMaps.PaymentMethods
{
    internal class CardNumberMap : IJsonTypeConfiguration<CardNumber>
    {
        public void Configure(JsonTypeBuilder<CardNumber> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.Length)
                .HasFieldName("length");

            jsonTypeBuilder.Property(x => x.Validation)
                .HasFieldName("validation");

        }
    }
}
