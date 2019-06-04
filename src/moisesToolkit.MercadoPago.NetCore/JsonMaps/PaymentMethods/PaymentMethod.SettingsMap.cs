
using MercadoPago.NetCore.Model.Resources.Dataclassures.PaymentMethod;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using Newtonsoft.Json.Converters;

namespace moisesToolkit.MercadoPago.NetCore.JsonMaps.PaymentMethods
{
    internal class SettingsMap : IJsonTypeConfiguration<Settings>
    {
        public void Configure(JsonTypeBuilder<Settings> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.Bin)
                .HasFieldName("bin");

            jsonTypeBuilder.Property(x => x.CardNumber)
                .HasFieldName("card_number");

            jsonTypeBuilder.Property(x => x.SecurityCode)
                .HasFieldName("security_code");

        }
    }
}
