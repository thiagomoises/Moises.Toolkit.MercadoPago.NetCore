using MercadoPago.NetCore.Model.Resources;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace moisesToolkit.MercadoPago.NetCore.HubClients
{
    public class PreapprovalHubClient : MercadoPagoHubClient
    {
        public PreapprovalHubClient(HttpClient httpClient, MPOptions options) : base(httpClient, options)
        {
        }
        public async System.Threading.Tasks.Task<List<Preapproval>> SearchAsync(Dictionary<string, string> mapParams)
        {
            var url = await MPUrlBuildAsync($"/preapproval/search", mapParams);
            var response = await Client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Preapproval>>(stringResponse, JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<Preapproval> FindAsync(string preapprovalId)
        {
            var url = await MPUrlBuildAsync($"/preapproval/{preapprovalId}");
            var response = await Client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Preapproval>(stringResponse, JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<bool> SaveAsync(Preapproval preapproval)
        {
            var url = await MPUrlBuildAsync($"/preapproval/");

            var content = new StringContent(JsonConvert.SerializeObject(preapproval), Encoding.UTF8, "application/json");
            var response = await Client.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            return true;
        }

        public async System.Threading.Tasks.Task<bool> UpdateAsync(Preapproval preapproval)
        {
            var url = await MPUrlBuildAsync($"/preapproval/{preapproval.Id}/");
            var content = new StringContent(JsonConvert.SerializeObject(preapproval), Encoding.UTF8, "application/json");
            var response = await Client.PutAsync(url, content);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            return true;
        }
    }
}
