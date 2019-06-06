using MercadoPago.NetCore.Model.Resources.Dataclassures.Preference;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;

namespace Moises.Toolkit.MercadoPago.NetCore.JsonMaps.Preferences
{
    internal class BackUrlsMap : IJsonTypeConfiguration<BackUrls>
    {
        public void Configure(JsonTypeBuilder<BackUrls> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.Success).HasFieldName("success");
            jsonTypeBuilder.Property(x => x.Pending).HasFieldName("pending");
            jsonTypeBuilder.Property(x => x.Failure).HasFieldName("failure");
        }
    }
}
