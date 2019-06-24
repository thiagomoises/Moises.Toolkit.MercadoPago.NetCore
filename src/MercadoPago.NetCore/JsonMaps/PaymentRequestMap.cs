using MercadoPago.NetCore.Model.Resources;
using MercadoPago.NetCore.Request;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using Newtonsoft.Json.Converters;

namespace Moises.Toolkit.MercadoPago.NetCore.JsonMaps
{
    internal class PaymentRequestMap : IJsonTypeConfiguration<PaymentRequest>
    {
        public void Configure(JsonTypeBuilder<PaymentRequest> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.IssuerId).HasFieldName("issuer_id");
            jsonTypeBuilder.Property(x => x.PaymentMethodId).HasFieldName("payment_method_id");
            jsonTypeBuilder.Property(x => x.CurrencyId)
                .HasFieldName("currency_id")
                .HasConverter(new StringEnumConverter());

            jsonTypeBuilder.Property(x => x.Description).HasFieldName("description");
            jsonTypeBuilder.Property(x => x.Payer).HasFieldName("payer");
            jsonTypeBuilder.Property(x => x.Metadata).HasFieldName("metadata");
            jsonTypeBuilder.Property(x => x.AdditionalInfo).HasFieldName("additional_info");
            jsonTypeBuilder.Property(x => x.Order).HasFieldName("order");
            jsonTypeBuilder.Property(x => x.ExternalReference).HasFieldName("external_reference");
            jsonTypeBuilder.Property(x => x.TransactionAmount).HasFieldName("transaction_amount");
            jsonTypeBuilder.Property(x => x.CouponAmount).HasFieldName("coupon_amount");
            jsonTypeBuilder.Property(x => x.DifferentialPricingId).HasFieldName("differential_pricing_id");
            jsonTypeBuilder.Property(x => x.Capture)
                .HasFieldName("capture")
                .AddDefaultValueHandling(Newtonsoft.Json.DefaultValueHandling.Include);
            jsonTypeBuilder.Property(x => x.BinaryMode).HasFieldName("binary_mode");
            jsonTypeBuilder.Property(x => x.StatementDescriptor).HasFieldName("statement_descriptor");
            jsonTypeBuilder.Property(x => x.NotificationUrl).HasFieldName("notification_url");
            jsonTypeBuilder.Property(x => x.Installments).HasFieldName("installments");
            jsonTypeBuilder.Property(x => x.Token).HasFieldName("token");
        }
    }
}
