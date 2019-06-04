using MercadoPago.NetCore.Model.Resources;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace moisesToolkit.MercadoPago.NetCore.JsonMaps
{
    internal class CardMap : IJsonTypeConfiguration<Card>
    {
        public void Configure(JsonTypeBuilder<Card> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.Id).HasFieldName("id");
            jsonTypeBuilder.Property(x => x.CustomerId).HasFieldName("customer_id");
            jsonTypeBuilder.Property(x => x.ExpirationMonth).HasFieldName("expiration_month");
            jsonTypeBuilder.Property(x => x.ExpirationYear).HasFieldName("expiration_year");
            jsonTypeBuilder.Property(x => x.FirstSixDigits).HasFieldName("first_six_digits");
            jsonTypeBuilder.Property(x => x.LastFourDigits).HasFieldName("last_four_digits");
            jsonTypeBuilder.Property(x => x.PaymentMethod).HasFieldName("payment_method");
            jsonTypeBuilder.Property(x => x.SecurityCode).HasFieldName("security_code");
            jsonTypeBuilder.Property(x => x.Issuer).HasFieldName("issuer");
            jsonTypeBuilder.Property(x => x.CardHolder).HasFieldName("cardholder");
            jsonTypeBuilder.Property(x => x.DateCreated).HasFieldName("date_created");
            jsonTypeBuilder.Property(x => x.DateLastUpdated).HasFieldName("date_last_updated");
        }
    }
}
