using MercadoPago.NetCore.Model.Resources;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using Newtonsoft.Json.Converters;

namespace Moises.Toolkit.MercadoPago.NetCore.JsonMaps
{
    internal class PaymentMap : IJsonTypeConfiguration<Payment>
    {
        public void Configure(JsonTypeBuilder<Payment> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.Id).HasFieldName("id");
            jsonTypeBuilder.Property(x => x.DateCreated).HasFieldName("date_created");
            jsonTypeBuilder.Property(x => x.DateApproved).HasFieldName("date_approved");
            jsonTypeBuilder.Property(x => x.DateLastUpdated).HasFieldName("date_last_updated");
            jsonTypeBuilder.Property(x => x.DateOfExpiration).HasFieldName("date_of_expiration");
            jsonTypeBuilder.Property(x => x.MoneyReleaseDate).HasFieldName("money_release_date");
            jsonTypeBuilder.Property(x => x.OperationType)
                .HasFieldName("operation_type")
                .HasConverter(new StringEnumConverter());
            jsonTypeBuilder.Property(x => x.IssuerId).HasFieldName("issuer_id");
            jsonTypeBuilder.Property(x => x.PaymentMethodId).HasFieldName("payment_method_id");
            jsonTypeBuilder.Property(x => x.PaymentTypeId)
                .HasFieldName("payment_type_id")
                .HasConverter(new StringEnumConverter());

            jsonTypeBuilder.Property(x => x.Status)
                .HasFieldName("status")
                .HasConverter(new StringEnumConverter());
            jsonTypeBuilder.Property(x => x.StatusDetail).HasFieldName("status_detail");
            jsonTypeBuilder.Property(x => x.CurrencyId)
                .HasFieldName("currency_id")
                .HasConverter(new StringEnumConverter());

            jsonTypeBuilder.Property(x => x.Description).HasFieldName("description");
            jsonTypeBuilder.Property(x => x.LiveMode).HasFieldName("live_mode");
            jsonTypeBuilder.Property(x => x.SponsorId).HasFieldName("sponsor_id");
            jsonTypeBuilder.Property(x => x.CollectorId).HasFieldName("collector_id");
            jsonTypeBuilder.Property(x => x.Payer).HasFieldName("payer");
            jsonTypeBuilder.Property(x => x.Metadata).HasFieldName("metadata");
            jsonTypeBuilder.Property(x => x.AdditionalInfo).HasFieldName("additional_info");
            jsonTypeBuilder.Property(x => x.Order).HasFieldName("order");
            jsonTypeBuilder.Property(x => x.ExternalReference).HasFieldName("external_reference");
            jsonTypeBuilder.Property(x => x.TransactionAmount).HasFieldName("transaction_amount");
            jsonTypeBuilder.Property(x => x.TransactionAmountRefunded).HasFieldName("transaction_amount_refunded");
            jsonTypeBuilder.Property(x => x.CouponAmount).HasFieldName("coupon_amount");
            jsonTypeBuilder.Property(x => x.DifferentialPricingId).HasFieldName("differential_pricing_id");
            jsonTypeBuilder.Property(x => x.TransactionDetails).HasFieldName("transaction_details");
            jsonTypeBuilder.Property(x => x.FeeDetails).HasFieldName("fee_details");
            jsonTypeBuilder.Property(x => x.Capture).HasFieldName("capture");
            jsonTypeBuilder.Property(x => x.Captured).HasFieldName("captured");
            jsonTypeBuilder.Property(x => x.BinaryMode).HasFieldName("binary_mode");
            jsonTypeBuilder.Property(x => x.CallForAuthorizeId).HasFieldName("call_for_authorize_id");
            jsonTypeBuilder.Property(x => x.StatementDescriptor).HasFieldName("statement_descriptor");
            jsonTypeBuilder.Property(x => x.Card).HasFieldName("card");
            jsonTypeBuilder.Property(x => x.NotificationUrl).HasFieldName("notification_url");
            jsonTypeBuilder.Property(x => x.Refunds).HasFieldName("refunds");
            jsonTypeBuilder.Property(x => x.ProcessingMode).HasFieldName("processing_mode");
            jsonTypeBuilder.Property(x => x.MerchantAccountId).HasFieldName("merchant_account_id");
            jsonTypeBuilder.Property(x => x.Installments).HasFieldName("installments");
        }
    }
}
