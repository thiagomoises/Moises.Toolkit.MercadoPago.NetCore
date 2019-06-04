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
            jsonTypeBuilder.Property(x => x.Id).HasFieldName("id");
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
            jsonTypeBuilder.Property(x => x.Email).HasFieldName("email");
            jsonTypeBuilder.Property(x => x.Cards).HasFieldName("cards");
            jsonTypeBuilder.Property(x => x.Address).HasFieldName("address");
            jsonTypeBuilder.Property(x => x.DateCreated).HasFieldName("date_created");
            jsonTypeBuilder.Property(x => x.DateLastUpdated).HasFieldName("date_last_updated");
            jsonTypeBuilder.Property(x => x.Addresses).HasFieldName("addresses");
            jsonTypeBuilder.Property(x => x.LiveMode).HasFieldName("liveMode");

        }
    }
}
