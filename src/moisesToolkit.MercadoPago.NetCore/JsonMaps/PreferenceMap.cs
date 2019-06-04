using MercadoPago.NetCore.Model.Resources;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using Newtonsoft.Json.Converters;
using System;

namespace moisesToolkit.MercadoPago.NetCore.JsonMaps
{
    public class PreferenceMap : IJsonTypeConfiguration<Preference>
    {
        public void Configure(JsonTypeBuilder<Preference> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.Items).HasFieldName("items");
            jsonTypeBuilder.Property(x => x.Payer).HasFieldName("payer");
            jsonTypeBuilder.Property(x => x.PaymentMethods).HasFieldName("payment_methods");
            jsonTypeBuilder.Property(x => x.Shipments).HasFieldName("shipments");
            jsonTypeBuilder.Property(x => x.BackUrls).HasFieldName("back_urls");
            jsonTypeBuilder.Property(x => x.NotificationUrl).HasFieldName("notification_url");
            jsonTypeBuilder.Property(x => x.Id).HasFieldName("id");
            jsonTypeBuilder.Property(x => x.InitPoint).HasFieldName("init_point");
            jsonTypeBuilder.Property(x => x.SandboxInitPoint).HasFieldName("sandbox_init_point");
            jsonTypeBuilder.Property(x => x.DateCreated).HasFieldName("date_created");
            jsonTypeBuilder.Property(x => x.OperationType).HasFieldName("operation_type")
                .HasConverter(new StringEnumConverter());
            jsonTypeBuilder.Property(x => x.AdditionalInfo).HasFieldName("additionalInfo");
            jsonTypeBuilder.Property(x => x.AutoReturn).HasFieldName("auto_return")
                .HasConverter(new StringEnumConverter());
            jsonTypeBuilder.Property(x => x.ExternalReference).HasFieldName("external_reference");
            jsonTypeBuilder.Property(x => x.Expires).HasFieldName("expires");
            jsonTypeBuilder.Property(x => x.ExpirationDateFrom).HasFieldName("expiration_date_from");
            jsonTypeBuilder.Property(x => x.ExpirationDateTo).HasFieldName("expiration_dateTo");
            jsonTypeBuilder.Property(x => x.CollectorId).HasFieldName("collector_id");
            jsonTypeBuilder.Property(x => x.ClientId).HasFieldName("client_id");
            jsonTypeBuilder.Property(x => x.Marketplace).HasFieldName("marketplace");
            jsonTypeBuilder.Property(x => x.MarketplaceFee).HasFieldName("marketplace_fee");
            jsonTypeBuilder.Property(x => x.DifferentialPricing).HasFieldName("differential_pricing");
            jsonTypeBuilder.Property(x => x.SponsorId).HasFieldName("sponsor_id");
            jsonTypeBuilder.Property(x => x.ProcessingModes).HasFieldName("processing_modes")
            jsonTypeBuilder.Property(x => x.BinaryMode).HasFieldName("binary_mode");
        }
    }
}
