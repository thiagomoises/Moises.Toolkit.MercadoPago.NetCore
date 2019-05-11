using MercadoPago.NetCore.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace moisesToolkit.MercadoPago.NetCore.HubClients
{
    public class PlanHubClient : MercadoPagoHubClient
    {
        public PlanHubClient(HttpClient httpClient, MPOptions options) : base(httpClient, options)
        {
        }

        public async System.Threading.Tasks.Task<Plan> FindAsync(string planId)
        {
            var url = await MPUrlBuildAsync($"/v1/plans/{planId}");
            var response = await Client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Plan>(stringResponse, JsonSerializerSettings);
        }


        public async System.Threading.Tasks.Task<bool> SaveAsync(Plan plan)
        {
            var url = await MPUrlBuildAsync($"/v1/plans/");

            var content = new StringContent(JsonConvert.SerializeObject(plan), Encoding.UTF8, "application/json");
            var response = await Client.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            return true;
        }

        public async System.Threading.Tasks.Task<bool> UpdateAsync(Plan plan)
        {
            var url = await MPUrlBuildAsync($"/v1/plans/{plan.Id}/");
            var content = new StringContent(JsonConvert.SerializeObject(plan), Encoding.UTF8, "application/json");
            var response = await Client.PutAsync(url, content);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            return true;
        }
    }
}
