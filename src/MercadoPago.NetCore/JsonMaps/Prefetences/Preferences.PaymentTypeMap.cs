using MercadoPago.NetCore.Model.Resources.Dataclassures.Preference;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;

namespace Moises.Toolkit.MercadoPago.NetCore.JsonMaps.Preferences
{
    internal class PaymentTypeMap : IJsonTypeConfiguration<PaymentType>
    {
        public void Configure(JsonTypeBuilder<PaymentType> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.Id).HasFieldName("id");
        }
    }
}
