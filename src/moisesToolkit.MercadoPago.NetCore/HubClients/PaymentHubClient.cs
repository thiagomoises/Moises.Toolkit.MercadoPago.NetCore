using MercadoPago.NetCore.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace moisesToolkit.MercadoPago.NetCore
{
    public partial class PaymentHubClient : MercadoPagoHubClient
    {
        public PaymentHubClient(HttpClient httpClient, MPOptions options) : base(httpClient, options)
        {
        }

        public async System.Threading.Tasks.Task<List<Payment>> GetPaymentsAsync()
        {
            var url = await MPUrlBuildAsync($"/v1/payments/search");
            var response = await Client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Payment>>(stringResponse, JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<List<Payment>> SearchAsync(Dictionary<string, string> mapParams)
        {
            var url = await MPUrlBuildAsync($"/v1/payments/search", mapParams);
            var response = await Client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Payment>>(stringResponse, JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<Payment> FindAsync(string paymentId)
        {
            var url = await MPUrlBuildAsync($"/v1/payments/{paymentId}");
            var response = await Client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Payment>(stringResponse, JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<bool> SaveAsync(Payment payment)
        {
            var url = await MPUrlBuildAsync($"/v1/payments/");

            var content = new StringContent(JsonConvert.SerializeObject(payment), Encoding.UTF8, "application/json");
            var response = await Client.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            return true;
        }

        public async System.Threading.Tasks.Task<bool> UpdateAsync(Payment payment)
        {
            var url = await MPUrlBuildAsync($"/v1/payments/{payment.Id}/");
            var content = new StringContent(JsonConvert.SerializeObject(payment), Encoding.UTF8, "application/json");
            var response = await Client.PutAsync(url, content);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            return true;
        }
    }
}
