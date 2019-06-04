using MercadoPago.NetCore.Model.DataStructures.Search;
using MercadoPago.NetCore.Model.Resources;
using moisesToolkit.MercadoPago.NetCore.HubClients;
using moisesToolkit.MercadoPago.NetCore.HubClients.Abstracts;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace moisesToolkit.MercadoPago.NetCore
{
    public partial class CardsHubClient : MercadoPagoHubClient
    {
        public CardsHubClient(HttpClient httpClient, MPOptions options, ITokenHubClient tokenHubClient) : base(httpClient, options, tokenHubClient)
        {
        }

        public async System.Threading.Tasks.Task<SearchResult<Card>> GetCardsAsync(string customerId)
        {
            var url = await MPUrlBuildAsync($"/v1/customers/{customerId}/cards");
            var response = await Client.GetAsync(url);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            return JsonConvert.DeserializeObject<SearchResult<Card>>(stringResponse, MPUtil.JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<Card> FindAsync(string customerId, string cardId)
        {
            var url = await MPUrlBuildAsync($"/v1/customers/{customerId}/cards/{cardId}");
            var response = await Client.GetAsync(url);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            return JsonConvert.DeserializeObject<Card>(stringResponse, MPUtil.JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<bool> SaveAsync(Card card)
        {
            var url = await MPUrlBuildAsync($"/v1/customers/{card.CustomerId}/cards/");

            var content = new StringContent(JsonConvert.SerializeObject(card, MPUtil.JsonSerializerSettings), Encoding.UTF8, "application/json");
            var response = await Client.PostAsync(url, content);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return false;
            return true;
        }

        public async System.Threading.Tasks.Task<bool> UpdateAsync(Card card)
        {
            var url = await MPUrlBuildAsync($"/v1/customers/{card.CustomerId}/cards/{card.Id}");
            var content = new StringContent(JsonConvert.SerializeObject(card, MPUtil.JsonSerializerSettings), Encoding.UTF8, "application/json");
            var response = await Client.PutAsync(url, content);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return false;
            return true;
        }

        public async System.Threading.Tasks.Task<List<Card>> DeleteAsync(Card card)
        {
            var url = await MPUrlBuildAsync($"/v1/customers/{card.CustomerId}/cards/{card.Id}");
            var response = await Client.DeleteAsync(url);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            return JsonConvert.DeserializeObject<List<Card>>(stringResponse, MPUtil.JsonSerializerSettings);
        }
    }
}
