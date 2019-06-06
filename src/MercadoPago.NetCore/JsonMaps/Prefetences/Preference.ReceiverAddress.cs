using MercadoPago.NetCore.Model.Resources.Dataclassures.Preference;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;

namespace Moises.Toolkit.MercadoPago.NetCore.JsonMaps.Preferences
{
    internal class ReceiverAddressMap : IJsonTypeConfiguration<ReceiverAddress>
    {
        public void Configure(JsonTypeBuilder<ReceiverAddress> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.ZipCode).HasFieldName("zip_code");
            jsonTypeBuilder.Property(x => x.StreetName).HasFieldName("street_name");
            jsonTypeBuilder.Property(x => x.StreetNumber).HasFieldName("street_number");
            jsonTypeBuilder.Property(x => x.Floor).HasFieldName("floor");
            jsonTypeBuilder.Property(x => x.Apartment).HasFieldName("apartament");
        }
    }
}
