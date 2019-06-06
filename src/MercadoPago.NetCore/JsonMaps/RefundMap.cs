using MercadoPago.NetCore.Model.Resources;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moises.Toolkit.MercadoPago.NetCore.JsonMaps
{
    internal class RefundMap : IJsonTypeConfiguration<Refund>
    {
        public void Configure(JsonTypeBuilder<Refund> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.Id)
                .HasFieldName("id");
            jsonTypeBuilder.Property(x => x.Amount)
                .HasFieldName("amount");
            jsonTypeBuilder.Property(x => x.PaymentId)
                .HasFieldName("payment_id");
            jsonTypeBuilder.Property(x => x.DateCreated)
                .HasFieldName("date_created");
            jsonTypeBuilder.Property(x => x.Errors)
                .HasFieldName("errors");
        }
    }
}
