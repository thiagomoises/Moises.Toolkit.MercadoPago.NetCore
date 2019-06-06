using MercadoPago.NetCore.Model.Resources.Dataclassures.Payment;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;

namespace Moises.Toolkit.MercadoPago.NetCore.JsonMaps.Payments
{
    internal class TransactionDetailMap : IJsonTypeConfiguration<TransactionDetail>
    {
        public void Configure(JsonTypeBuilder<TransactionDetail> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.NetReceivedAmount).HasFieldName("net_received_amount");
            jsonTypeBuilder.Property(x => x.TotalPaidAmount).HasFieldName("total_paid_amount");
            jsonTypeBuilder.Property(x => x.OverpaidAmount).HasFieldName("overpaid_amount");
            jsonTypeBuilder.Property(x => x.ExternalResourceUrl).HasFieldName("external_resource_url");
            jsonTypeBuilder.Property(x => x.InstallmentAmount).HasFieldName("installment_amount");
            jsonTypeBuilder.Property(x => x.FinancialInstitution).HasFieldName("financial_institution");
            jsonTypeBuilder.Property(x => x.PaymentMethodReferenceId).HasFieldName("payment_method_reference_id");
        }
    }
}
