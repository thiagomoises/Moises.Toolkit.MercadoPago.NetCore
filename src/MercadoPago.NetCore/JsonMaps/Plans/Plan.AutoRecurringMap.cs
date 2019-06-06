using MercadoPago.NetCore.Model.Resources.Dataclassures.Plan;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using Newtonsoft.Json.Converters;

namespace Moises.Toolkit.MercadoPago.NetCore.JsonMaps.Plans
{
    internal class AutoRecurringMap : IJsonTypeConfiguration<AutoRecurring>
    {
        public void Configure(JsonTypeBuilder<AutoRecurring> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.Frequency).HasFieldName("frequency");
            jsonTypeBuilder.Property(x => x.FrequencyType).HasFieldName("frequency_type")
                .HasConverter(new StringEnumConverter());
            jsonTypeBuilder.Property(x => x.TransactionAmount).HasFieldName("transaction_amount");
            jsonTypeBuilder.Property(x => x.CurrencyId).HasFieldName("currency_id")
                .HasConverter(new StringEnumConverter());
            jsonTypeBuilder.Property(x => x.Repetitions).HasFieldName("repetitions");
            jsonTypeBuilder.Property(x => x.DebitDate).HasFieldName("debit_date");
            jsonTypeBuilder.Property(x => x.FreeTrial).HasFieldName("reason");
        }
    }
}
