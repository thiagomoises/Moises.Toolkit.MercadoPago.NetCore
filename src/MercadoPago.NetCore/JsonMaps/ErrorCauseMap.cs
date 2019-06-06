using MercadoPago.NetCore.Model.Resources.Errors;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;

namespace Moises.Toolkit.MercadoPago.NetCore.JsonMaps
{
    internal class ErrorCauseMap : IJsonTypeConfiguration<ErrorCause>
    {
        public void Configure(JsonTypeBuilder<ErrorCause> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.Code)
                .HasFieldName("code");
            jsonTypeBuilder.Property(x => x.Description)
                .HasFieldName("description");
        }
    }
}
