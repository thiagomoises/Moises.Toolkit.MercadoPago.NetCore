using MercadoPago.NetCore.Model.Resources.Dataclassures.MerchantOrder;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using Newtonsoft.Json.Converters;
using System;

namespace moisesToolkit.MercadoPago.NetCore.JsonMaps.MerchantOrders
{
    internal class MerchantOrderPaymentMap : IJsonTypeConfiguration<MerchantOrderPayment>
    {
        public void Configure(JsonTypeBuilder<MerchantOrderPayment> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.Id).HasFieldName("id");
            jsonTypeBuilder.Property(x => x.TransactionAmount).HasFieldName("transaction_amount");
            jsonTypeBuilder.Property(x => x.TotalPaidAmount).HasFieldName("total_papid_amount");
            jsonTypeBuilder.Property(x => x.ShippingCost).HasFieldName("shipping_cost");
            jsonTypeBuilder.Property(x => x.PaymentCurrencyId)
                .HasConverter(new StringEnumConverter())
                .HasFieldName("currency_id");
            jsonTypeBuilder.Property(x => x.Status).HasFieldName("status");
            jsonTypeBuilder.Property(x => x.StatusDetail).HasFieldName("status_detail");
            jsonTypeBuilder.Property(x => x.PaymentOperationType).HasFieldName("operation_type");
            jsonTypeBuilder.Property(x => x.DateApproved).HasFieldName("date_approved");
            jsonTypeBuilder.Property(x => x.DateCreated).HasFieldName("date_created");
            jsonTypeBuilder.Property(x => x.LastModified).HasFieldName("last_modified");
            jsonTypeBuilder.Property(x => x.AmountRefunded).HasFieldName("amount_refunded");
            }
    }
}
