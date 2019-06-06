using MercadoPago.NetCore.Model.Resources;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;

namespace Moises.Toolkit.MercadoPago.NetCore.JsonMaps
{
    internal class SubscriptionMap : IJsonTypeConfiguration<Subscription>
    {
        public void Configure(JsonTypeBuilder<Subscription> jsonTypeBuilder)
        {
        }
    }
}
