using MercadoPago.NetCore.Model.Resources;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using Newtonsoft.Json.Converters;

namespace Moises.Toolkit.MercadoPago.NetCore.JsonMaps
{
    internal class PaymentMethodMap : IJsonTypeConfiguration<PaymentMethod>
    {
        public void Configure(JsonTypeBuilder<PaymentMethod> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.Id).HasFieldName("id");
            jsonTypeBuilder.Property(x => x.Name).HasFieldName("name");
            jsonTypeBuilder.Property(x => x.Settings).HasFieldName("settings");
            jsonTypeBuilder.Property(x => x.AdditionalInfoNeeded).HasFieldName("additional_info_needed");
            jsonTypeBuilder.Property(x => x.MinAllowedAmount).HasFieldName("min_allowed_amount");
            jsonTypeBuilder.Property(x => x.MaxAllowedAmount).HasFieldName("max_allowed_amount");
            jsonTypeBuilder.Property(x => x.AccreditationTime).HasFieldName("accreditation_time");
            jsonTypeBuilder.Property(x => x.FinancialInstitutions).HasFieldName("financial_institutions");
            jsonTypeBuilder.Property(x => x.ProcessingMode).HasFieldName("processing_mode");
            jsonTypeBuilder.Property(x => x.SecureThumbail).HasFieldName("secure_thumbnail");
            jsonTypeBuilder.Property(x => x.Thumbail).HasFieldName("thumbnail");

            jsonTypeBuilder.Property(x => x.PaymentTypeId)
                .HasFieldName("payment_type_id")
                .HasConverter(new StringEnumConverter());

            jsonTypeBuilder.Property(x => x.Status)
                .HasFieldName("status")
                .HasConverter(new StringEnumConverter());

            jsonTypeBuilder.Property(x => x.DeferredCapture)
                .HasFieldName("deferred_capture")
                .HasConverter(new StringEnumConverter());


        }
    }
}
