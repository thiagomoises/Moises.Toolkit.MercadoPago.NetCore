using MercadoPago.NetCore.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;

namespace moisesToolkit.MercadoPago.NetCore
{
    public partial class PaymentMethodHubClient : MercadoPagoHubClient
    {
        public PaymentMethodHubClient(HttpClient httpClient, MPOptions options) : base(httpClient, options)
        {
        }

        public async System.Threading.Tasks.Task<List<PaymentMethod>> GetPaymentMethods()
        {
            var url = await MPUrlBuildAsync($"/v1/payment_methods");
            var response = await Client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<PaymentMethod>>(stringResponse, JsonSerializerSettings);
        }
    }
}
