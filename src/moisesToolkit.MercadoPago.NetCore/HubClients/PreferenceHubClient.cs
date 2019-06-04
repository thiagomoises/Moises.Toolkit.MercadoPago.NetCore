using MercadoPago.NetCore.Model.Resources;
using moisesToolkit.MercadoPago.NetCore.HubClients.Abstracts;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace moisesToolkit.MercadoPago.NetCore.HubClients
{
    public class PreferenceHubClient : MercadoPagoHubClient, IPreferenceHubClient
    {
        public PreferenceHubClient(HttpClient httpClient, MPOptions options, ITokenHubClient tokenHubClient) : base(httpClient, options, tokenHubClient)
        {
        }

        public async System.Threading.Tasks.Task<Preference> FindAsync(string preferenceId)
        {
            if (string.IsNullOrEmpty(preferenceId))
            {
                this.AddNotification("preferenceId", "preferenceId is Required");
            }

            if (this.IsInvalid())
                return null;

            var url = await MPUrlBuildAsync($"/checkout/preferences/{preferenceId}");
            var response = await Client.GetAsync(url);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            return JsonConvert.DeserializeObject<Preference>(stringResponse, MPUtil.JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<Preference> SaveAsync(Preference preference)
        {
            if (preference is null)
            {
                this.AddNotification("preference", "preference is Required");
            }

            if (this.IsInvalid())
                return null;

            var url = await MPUrlBuildAsync($"/checkout/preferences/");

            var content = new StringContent(JsonConvert.SerializeObject(preference, MPUtil.JsonSerializerSettings), Encoding.UTF8, "application/json");
            var response = await Client.PostAsync(url, content);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            return JsonConvert.DeserializeObject<Preference>(stringResponse, MPUtil.JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<Preference> UpdateAsync(Preference preference)
        {
            if (preference is null)
            {
                this.AddNotification("preference", "preference is Required");
            }

            if (this.IsInvalid())
                return null;

            var url = await MPUrlBuildAsync($"/checkout/preferences/{preference.Id}/");
            var content = new StringContent(JsonConvert.SerializeObject(preference, MPUtil.JsonSerializerSettings), Encoding.UTF8, "application/json");
            var response = await Client.PutAsync(url, content);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            return JsonConvert.DeserializeObject<Preference>(stringResponse, MPUtil.JsonSerializerSettings);
        }
    }
}
