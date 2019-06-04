using MercadoPago.NetCore.Model.Resources.Dataclassures.Preference;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;

namespace moisesToolkit.MercadoPago.NetCore.JsonMaps.Preferences
{
    internal class AddressMap : IJsonTypeConfiguration<Address>
    {
        public void Configure(JsonTypeBuilder<Address> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.StreetName).HasFieldName("street_name");
            jsonTypeBuilder.Property(x => x.StreetNumber).HasFieldName("street_number");
            jsonTypeBuilder.Property(x => x.ZipCode).HasFieldName("zip_code");
        }
    }
}
