using MercadoPago.NetCore.Model.Resources;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;

namespace Moises.Toolkit.MercadoPago.NetCore.JsonMaps
{
    internal class MerchantOrderMap : IJsonTypeConfiguration<MerchantOrder>
    {
        public void Configure(JsonTypeBuilder<MerchantOrder> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.Id).HasFieldName("id");
            jsonTypeBuilder.Property(x => x.PreferenceId).HasFieldName("preference_id");
            jsonTypeBuilder.Property(x => x.DateCreated).HasFieldName("date_created");
            jsonTypeBuilder.Property(x => x.LastUpdate).HasFieldName("last_update");
            jsonTypeBuilder.Property(x => x.ApplicationId).HasFieldName("application_id");
            jsonTypeBuilder.Property(x => x.Status).HasFieldName("status");
            jsonTypeBuilder.Property(x => x.SiteId).HasFieldName("site_id");
            jsonTypeBuilder.Property(x => x.Payer).HasFieldName("payer");
            jsonTypeBuilder.Property(x => x.Collector).HasFieldName("collector");
            jsonTypeBuilder.Property(x => x.SponsorId).HasFieldName("sponsor_id");
            jsonTypeBuilder.Property(x => x.Payments).HasFieldName("payments");
            jsonTypeBuilder.Property(x => x.PaidAmount).HasFieldName("paid_amount");
            jsonTypeBuilder.Property(x => x.RefundedAmount).HasFieldName("refunded_amount");
            jsonTypeBuilder.Property(x => x.ShippingCost).HasFieldName("shipping_cost");
            jsonTypeBuilder.Property(x => x.Cancelled).HasFieldName("cancelled");
            jsonTypeBuilder.Property(x => x.Items).HasFieldName("items");
            jsonTypeBuilder.Property(x => x.Shipments).HasFieldName("shipments");
            jsonTypeBuilder.Property(x => x.NotificationUrl).HasFieldName("notification_url");
            jsonTypeBuilder.Property(x => x.AdditionalInfo).HasFieldName("additional_info");
            jsonTypeBuilder.Property(x => x.ExternalReference).HasFieldName("external_reference");
            jsonTypeBuilder.Property(x => x.Marketplace).HasFieldName("marketplace");
            jsonTypeBuilder.Property(x => x.TotalAmount).HasFieldName("total_amount");

        }
    }
}
