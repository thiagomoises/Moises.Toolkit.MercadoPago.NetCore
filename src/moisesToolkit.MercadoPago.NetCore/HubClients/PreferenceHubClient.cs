using MercadoPago.NetCore.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace moisesToolkit.MercadoPago.NetCore.HubClients
{
    public class PreferenceHubClient : MercadoPagoHubClient
    {
        public PreferenceHubClient(HttpClient httpClient, MPOptions options) : base(httpClient, options)
        {
        }
        
        public async System.Threading.Tasks.Task<List<Preference>> FindAsync(string preferenceId)
        {
            var url = await MPUrlBuildAsync($"/checkout/preferences/{preferenceId}");
            var response = await Client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Preference>>(stringResponse, JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<bool> SaveAsync(Preference preference)
        {
            var url = await MPUrlBuildAsync($"/checkout/preferences/");

            var content = new StringContent(JsonConvert.SerializeObject(preference), Encoding.UTF8, "application/json");
            var response = await Client.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            return true;
        }

        public async System.Threading.Tasks.Task<bool> UpdateAsync(Preference preference)
        {
            var url = await MPUrlBuildAsync($"/checkout/preferences/{preference.Id}/");
            var content = new StringContent(JsonConvert.SerializeObject(preference), Encoding.UTF8, "application/json");
            var response = await Client.PutAsync(url, content);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            return true;
        }
    }
}
