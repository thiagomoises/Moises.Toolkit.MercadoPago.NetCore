using MercadoPago.NetCore.Model.Resources;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace moisesToolkit.MercadoPago.NetCore.JsonMaps
{
    internal class CustomerMap : IJsonTypeConfiguration<Customer>
    {
        public void Configure(JsonTypeBuilder<Customer> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.FirstName).HasFieldName("first_name");
            jsonTypeBuilder.Property(x => x.LastName).HasFieldName("last_name");
            jsonTypeBuilder.Property(x => x.Phone).HasFieldName("phone");
            jsonTypeBuilder.Property(x => x.Identification).HasFieldName("identification");
            jsonTypeBuilder.Property(x => x.DefaultAddress).HasFieldName("default_address");
            jsonTypeBuilder.Property(x => x.Address).HasFieldName("address");
            jsonTypeBuilder.Property(x => x.DateRegistered).HasFieldName("date_registred");
            jsonTypeBuilder.Property(x => x.Description).HasFieldName("description");
            jsonTypeBuilder.Property(x => x.Metadata).HasFieldName("metadata");
            jsonTypeBuilder.Property(x => x.DefaultCard).HasFieldName("default_card");
        }
    }
}
