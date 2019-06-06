using MercadoPago.NetCore.Model.Resources.Dataclassures.Preference;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;

namespace Moises.Toolkit.MercadoPago.NetCore.JsonMaps.Preferences
{
    internal class PaymentMethodsMap : IJsonTypeConfiguration<PreferencePaymentMethods>
    {
        public void Configure(JsonTypeBuilder<PreferencePaymentMethods> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.ExcludedPaymentMethods).HasFieldName("excluded_payment_methods");
            jsonTypeBuilder.Property(x => x.ExcludedPaymentTypes).HasFieldName("excluded_payment_types");
            jsonTypeBuilder.Property(x => x.DefaultPaymentMethodId).HasFieldName("default_payment_method_id");
            jsonTypeBuilder.Property(x => x.Installments).HasFieldName("installments");
            jsonTypeBuilder.Property(x => x.DefaultInstallments).HasFieldName("default_installments");
        }
    }

    internal class PaymentMethodMap : IJsonTypeConfiguration<PaymentMethod>
    {
        public void Configure(JsonTypeBuilder<PaymentMethod> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.Id).HasFieldName("id");
        }
    }
}
