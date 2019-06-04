using MercadoPago.NetCore.Model.Resources.Errors;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;

namespace moisesToolkit.MercadoPago.NetCore.JsonMaps
{
    internal class ErrorResultMap : IJsonTypeConfiguration<ErrorResult>
    {
        public void Configure(JsonTypeBuilder<ErrorResult> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.Causes)
                .HasFieldName("cause");
            jsonTypeBuilder.Property(x => x.Error)
                .HasFieldName("error");
            jsonTypeBuilder.Property(x => x.Message)
                .HasFieldName("message");
            jsonTypeBuilder.Property(x => x.Status)
                .HasFieldName("status");
        }
    }
}
