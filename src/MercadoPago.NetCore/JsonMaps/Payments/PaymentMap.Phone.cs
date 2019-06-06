using MercadoPago.NetCore.Model.Resources.Dataclassures.Payment;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;

namespace Moises.Toolkit.MercadoPago.NetCore.JsonMaps.Payments
{
    internal class PhoneMap : IJsonTypeConfiguration<Phone>
    {
        public void Configure(JsonTypeBuilder<Phone> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.AreaCode).HasFieldName("area_code");
            jsonTypeBuilder.Property(x => x.Number).HasFieldName("number");
            jsonTypeBuilder.Property(x => x.Extension).HasFieldName("extension");
        }
    }
}
