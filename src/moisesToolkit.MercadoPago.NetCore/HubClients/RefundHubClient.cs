using MercadoPago.NetCore.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace moisesToolkit.MercadoPago.NetCore.HubClients
{
    public class RefundHubClient : MercadoPagoHubClient
    {
        public RefundHubClient(HttpClient httpClient, MPOptions options) : base(httpClient, options)
        {
        }
        
        public async System.Threading.Tasks.Task<bool> SaveAsync(Refund refund)
        {
            var url = await MPUrlBuildAsync($"/v1/payments/{refund.PaymentId}/refunds");
            var content = new StringContent(JsonConvert.SerializeObject(refund), Encoding.UTF8, "application/json");
            var response = await Client.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            return true;
        }

    }
}
