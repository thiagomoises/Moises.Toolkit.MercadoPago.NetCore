using MercadoPago.NetCore.Model.Resources.Dataclassures.Customer;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moises.Toolkit.MercadoPago.NetCore.JsonMaps.Costumers
{
    internal class PhoneMap : IJsonTypeConfiguration<Phone>
    {
        public void Configure(JsonTypeBuilder<Phone> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.AreaCode).HasFieldName("area_code");
            jsonTypeBuilder.Property(x => x.Number).HasFieldName("number");
        }
    }
}
