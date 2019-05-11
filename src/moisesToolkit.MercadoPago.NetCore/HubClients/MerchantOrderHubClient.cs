using MercadoPago.NetCore.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace moisesToolkit.MercadoPago.NetCore
{
    public partial class MerchantOrderHubClient : MercadoPagoHubClient
    {
        public MerchantOrderHubClient(HttpClient httpClient, MPOptions options) : base(httpClient, options)
        {
        }

        public async System.Threading.Tasks.Task<MerchantOrder> FindAsync(string merchantOrderId)
        {
            var url = await MPUrlBuildAsync($"/v1/merchant_orders/{merchantOrderId}");
            var response = await Client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<MerchantOrder>(stringResponse, JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<bool> SaveAsync(MerchantOrder merchantOrder)
        {
            var url = await MPUrlBuildAsync($"/v1/merchant_orders/");

            var content = new StringContent(JsonConvert.SerializeObject(merchantOrder), Encoding.UTF8, "application/json");
            var response = await Client.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            return true;
        }

        public async System.Threading.Tasks.Task<bool> UpdateAsync(MerchantOrder merchantOrder)
        {
            var url = await MPUrlBuildAsync($"/v1/merchant_orders/{merchantOrder.Id}/");
            var content = new StringContent(JsonConvert.SerializeObject(merchantOrder), Encoding.UTF8, "application/json");
            var response = await Client.PutAsync(url, content);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            return true;
        }
    }
}
