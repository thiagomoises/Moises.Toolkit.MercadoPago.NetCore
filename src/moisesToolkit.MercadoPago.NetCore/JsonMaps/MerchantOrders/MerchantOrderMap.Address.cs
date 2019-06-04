using MercadoPago.NetCore.Model.Resources.Dataclassures.MerchantOrder;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;

namespace moisesToolkit.MercadoPago.NetCore.JsonMaps.MerchantOrders
{
    internal class AddressMap : IJsonTypeConfiguration<Address>
    {
        public void Configure(JsonTypeBuilder<Address> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.ZipCode).HasFieldName("zip_code");
            jsonTypeBuilder.Property(x => x.StreetName).HasFieldName("street_name");
            jsonTypeBuilder.Property(x => x.StreetNumber).HasFieldName("street_number");
            jsonTypeBuilder.Property(x => x.Floor).HasFieldName("floor");
            jsonTypeBuilder.Property(x => x.Apartment).HasFieldName("apartament");
        }
    }
}
