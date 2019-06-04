using MercadoPago.NetCore.Model.Resources;
using moisesToolkit.MercadoPago.NetCore.HubClients.Abstracts;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace moisesToolkit.MercadoPago.NetCore.HubClients
{
    public class PreferenceHubClient : MercadoPagoHubClient
    {
        public PreferenceHubClient(HttpClient httpClient, MPOptions options, ITokenHubClient tokenHubClient) : base(httpClient, options, tokenHubClient)
        {
        }
        
        public async System.Threading.Tasks.Task<List<Preference>> FindAsync(string preferenceId)
        {
            var url = await MPUrlBuildAsync($"/checkout/preferences/{preferenceId}");
            var response = await Client.GetAsync(url);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            return JsonConvert.DeserializeObject<List<Preference>>(stringResponse, MPUtil.JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<bool> SaveAsync(Preference preference)
        {
            var url = await MPUrlBuildAsync($"/checkout/preferences/");

            var content = new StringContent(JsonConvert.SerializeObject(preference, MPUtil.JsonSerializerSettings), Encoding.UTF8, "application/json");
            var response = await Client.PostAsync(url, content);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return false;
            return true;
        }

        public async System.Threading.Tasks.Task<bool> UpdateAsync(Preference preference)
        {
            var url = await MPUrlBuildAsync($"/checkout/preferences/{preference.Id}/");
            var content = new StringContent(JsonConvert.SerializeObject(preference, MPUtil.JsonSerializerSettings), Encoding.UTF8, "application/json");
            var response = await Client.PutAsync(url, content);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return false;
            return true;
        }
    }
}
