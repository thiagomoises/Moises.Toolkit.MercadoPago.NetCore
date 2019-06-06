using MercadoPago.NetCore.Model.Resources.Dataclassures.Preference;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using Newtonsoft.Json.Converters;

namespace Moises.Toolkit.MercadoPago.NetCore.JsonMaps.Preferences
{
    internal class ItemMap : IJsonTypeConfiguration<Item>
    {
        public void Configure(JsonTypeBuilder<Item> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.Id).HasFieldName("_id");
            jsonTypeBuilder.Property(x => x.Title).HasFieldName("_title");
            jsonTypeBuilder.Property(x => x.Description).HasFieldName("_description");
            jsonTypeBuilder.Property(x => x.PictureUrl).HasFieldName("_pictureU_url");
            jsonTypeBuilder.Property(x => x.CategoryId).HasFieldName("_category_id");
            jsonTypeBuilder.Property(x => x.Quantity).HasFieldName("_quantity");
            jsonTypeBuilder.Property(x => x.CurrencyId)
                .HasFieldName("_currency_id")
                .HasConverter(new StringEnumConverter());
            jsonTypeBuilder.Property(x => x.UnitPrice).HasFieldName("unit_price");

        }
    }
}
