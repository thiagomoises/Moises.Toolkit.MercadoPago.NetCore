
using MercadoPago.NetCore.Model.Resources.Dataclassures.PaymentMethod;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using Newtonsoft.Json.Converters;

namespace moisesToolkit.MercadoPago.NetCore.JsonMaps.PaymentMethods
{
    internal class BinMap : IJsonTypeConfiguration<Bin>
    {
        public void Configure(JsonTypeBuilder<Bin> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.Pattern)
                .HasFieldName("pattern");

            jsonTypeBuilder.Property(x => x.ExclusionPattern)
                .HasFieldName("exclusion_pattern");

            jsonTypeBuilder.Property(x => x.InstallmentsPattern)
                .HasFieldName("installments_pattern");

        }
    }
}
