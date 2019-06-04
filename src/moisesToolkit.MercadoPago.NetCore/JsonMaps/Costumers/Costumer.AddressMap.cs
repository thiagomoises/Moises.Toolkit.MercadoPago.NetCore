using MercadoPago.NetCore.Model.Resources.Dataclassures.Customer;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace moisesToolkit.MercadoPago.NetCore.JsonMaps.Costumers
{
    internal class AddressMap : IJsonTypeConfiguration<Address>
    {
        public void Configure(JsonTypeBuilder<Address> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.Id).HasFieldName("id");
            jsonTypeBuilder.Property(x => x.StreetName).HasFieldName("street_name");
            jsonTypeBuilder.Property(x => x.StreetNumber).HasFieldName("street_number");
            jsonTypeBuilder.Property(x => x.ZipCode).HasFieldName("zip_code");
        }
    }
}
