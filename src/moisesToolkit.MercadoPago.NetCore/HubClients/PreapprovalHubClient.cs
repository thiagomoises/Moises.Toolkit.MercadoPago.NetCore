using MercadoPago.NetCore.Model.DataStructures.Search;
using MercadoPago.NetCore.Model.Resources;
using moisesToolkit.MercadoPago.NetCore.HubClients.Abstracts;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace moisesToolkit.MercadoPago.NetCore.HubClients
{
    public class PreapprovalHubClient : MercadoPagoHubClient, IPreapprovalHubClient
    {
        public PreapprovalHubClient(HttpClient httpClient, MPOptions options, ITokenHubClient tokenHubClient) : base(httpClient, options, tokenHubClient)
        {
        }
        public async System.Threading.Tasks.Task<SearchResult<Preapproval>> SearchAsync(Dictionary<string, string> mapParams)
        {
            var url = await MPUrlBuildAsync($"/preapproval/search", mapParams);
            var response = await Client.GetAsync(url);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            return JsonConvert.DeserializeObject<SearchResult<Preapproval>>(stringResponse, MPUtil.JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<Preapproval> FindAsync(string preapprovalId)
        {
            if (string.IsNullOrEmpty(preapprovalId))
            {
                this.AddNotification("preapprovalId", "preapprovalId is Required");
            }

            if (this.IsInvalid())
                return null;

            var url = await MPUrlBuildAsync($"/preapproval/{preapprovalId}");
            var response = await Client.GetAsync(url);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            return JsonConvert.DeserializeObject<Preapproval>(stringResponse, MPUtil.JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<Preapproval> SaveAsync(Preapproval preapproval)
        {
            if (preapproval is null)
            {
                this.AddNotification("preapproval", "preapproval is Required");
            }

            if (this.IsInvalid())
                return null;

            var url = await MPUrlBuildAsync($"/preapproval/");

            var content = new StringContent(JsonConvert.SerializeObject(preapproval, MPUtil.JsonSerializerSettings), Encoding.UTF8, "application/json");
            var response = await Client.PostAsync(url, content);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            return JsonConvert.DeserializeObject<Preapproval>(stringResponse, MPUtil.JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<Preapproval> UpdateAsync(Preapproval preapproval)
        {
            if (preapproval is null)
            {
                this.AddNotification("preapproval", "preapproval is Required");
            }

            if (this.IsInvalid())
                return null;

            var url = await MPUrlBuildAsync($"/preapproval/{preapproval.Id}/");
            var content = new StringContent(JsonConvert.SerializeObject(preapproval, MPUtil.JsonSerializerSettings), Encoding.UTF8, "application/json");
            var response = await Client.PutAsync(url, content);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            return JsonConvert.DeserializeObject<Preapproval>(stringResponse, MPUtil.JsonSerializerSettings);
        }
    }
}
