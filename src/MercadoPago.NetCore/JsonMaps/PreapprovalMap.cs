using MercadoPago.NetCore.Model.Resources;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using System;

namespace Moises.Toolkit.MercadoPago.NetCore.JsonMaps
{
    public class PreapprovalMap : IJsonTypeConfiguration<Preapproval>
    {
        public void Configure(JsonTypeBuilder<Preapproval> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.PayerEmail).HasFieldName("payer_email");
            jsonTypeBuilder.Property(x => x.BackUrl).HasFieldName("back_url");
            jsonTypeBuilder.Property(x => x.Id).HasFieldName("id");
            jsonTypeBuilder.Property(x => x.InitPoint).HasFieldName("init_point");
            jsonTypeBuilder.Property(x => x.SandboxInitPoint).HasFieldName("sandbox_init_point");
            jsonTypeBuilder.Property(x => x.ExternalReference).HasFieldName("external_reference");
            jsonTypeBuilder.Property(x => x.Reason).HasFieldName("reason");
            jsonTypeBuilder.Property(x => x.AutoRecurring).HasFieldName("auto_recurring");
        }
    }
}
