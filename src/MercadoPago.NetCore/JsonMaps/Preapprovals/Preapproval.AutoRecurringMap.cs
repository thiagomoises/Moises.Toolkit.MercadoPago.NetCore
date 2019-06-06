using MercadoPago.NetCore.Model.Resources.Dataclassures.Preapproval;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using Newtonsoft.Json.Converters;

namespace Moises.Toolkit.MercadoPago.NetCore.JsonMaps.Preapprovals
{
    internal class AutoRecurringMap : IJsonTypeConfiguration<AutoRecurring>
    {
        public void Configure(JsonTypeBuilder<AutoRecurring> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.Frequency).HasFieldName("frequency");

            jsonTypeBuilder.Property(x => x.FrequencyType)
                .HasFieldName("frequency_type")
                .HasConverter(new StringEnumConverter());

            jsonTypeBuilder.Property(x => x.TransactionAmount).HasFieldName("transaction_amount");

            jsonTypeBuilder.Property(x => x.CurrencyId)
                .HasFieldName("currency_id")
                .HasConverter(new StringEnumConverter()); 

            jsonTypeBuilder.Property(x => x.StartDate).HasFieldName("start_date");
            jsonTypeBuilder.Property(x => x.EndDate).HasFieldName("end_date");
        }
    }
}
