using MercadoPago.NetCore.Model.Resources;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using System;

namespace moisesToolkit.MercadoPago.NetCore.JsonMaps
{
    public class PlanMap : IJsonTypeConfiguration<Plan>
    {
        public void Configure(JsonTypeBuilder<Plan> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.Id).HasFieldName("id");
            jsonTypeBuilder.Property(x => x.ApplicationFee).HasFieldName("application_fee");
            jsonTypeBuilder.Property(x => x.Status).HasFieldName("status");
            jsonTypeBuilder.Property(x => x.Description).HasFieldName("description");
            jsonTypeBuilder.Property(x => x.ExternalReference).HasFieldName("external_reference");
            jsonTypeBuilder.Property(x => x.DateCreated).HasFieldName("date_created");
            jsonTypeBuilder.Property(x => x.LastModified).HasFieldName("last_modified");
            jsonTypeBuilder.Property(x => x.AutoRecurring).HasFieldName("auto_recurring");
            jsonTypeBuilder.Property(x => x.LiveMode).HasFieldName("live_mode");
            jsonTypeBuilder.Property(x => x.SetupFee).HasFieldName("setup_fee");
            jsonTypeBuilder.Property(x => x.Metadata).HasFieldName("metadata");
        }
    }
}
