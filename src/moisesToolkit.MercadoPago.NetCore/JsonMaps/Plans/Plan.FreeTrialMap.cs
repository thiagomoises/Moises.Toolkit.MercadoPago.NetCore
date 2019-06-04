using MercadoPago.NetCore.Model.Resources.Dataclassures.Plan;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using Newtonsoft.Json.Converters;

namespace moisesToolkit.MercadoPago.NetCore.JsonMaps.Plans
{
    internal class FreeTrialMap : IJsonTypeConfiguration<FreeTrial>
    {
        public void Configure(JsonTypeBuilder<FreeTrial> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.Frequency).HasFieldName("frequency");
            jsonTypeBuilder.Property(x => x.FrequencyType).HasFieldName("frequency_type")
                .HasConverter(new StringEnumConverter());
        }
    }
}
