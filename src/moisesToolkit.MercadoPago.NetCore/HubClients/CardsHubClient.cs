using MercadoPago.NetCore.Model.DataStructures.Search;
using MercadoPago.NetCore.Model.Resources;
using moisesToolkit.MercadoPago.NetCore.HubClients.Abstracts;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace moisesToolkit.MercadoPago.NetCore.HubClients
{
    public partial class CardsHubClient : MercadoPagoHubClient, ICardsHubClient
    {
        public CardsHubClient(IHttpClientFactory httpClientFactory, MPOptions options, ITokenHubClient tokenHubClient) : base(httpClientFactory, options, tokenHubClient)
        {
        }

        public async System.Threading.Tasks.Task<SearchResult<Card>> GetCardsAsync(string customerId)
        {
            if (string.IsNullOrEmpty(customerId))
            {
                this.AddNotification("customerId", "customerId is Required");
            }

            if (this.IsInvalid())
                return null;

            var url = await MPUrlBuildAsync($"/v1/customers/{customerId}/cards");
            var response = await Client.GetAsync(url);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            return JsonConvert.DeserializeObject<SearchResult<Card>>(stringResponse, MPUtil.JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<Card> FindAsync(string customerId, string cardId)
        {
            if (string.IsNullOrEmpty(customerId))
            {
                this.AddNotification("customerId", "customerId is Required");
            }

            if (string.IsNullOrEmpty(cardId))
            {
                this.AddNotification("cardId", "cardId is Required");
            }

            if (this.IsInvalid())
                return null;

            var url = await MPUrlBuildAsync($"/v1/customers/{customerId}/cards/{cardId}");
            var response = await Client.GetAsync(url);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            return JsonConvert.DeserializeObject<Card>(stringResponse, MPUtil.JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<Card> SaveAsync(Card card)
        {
            if (card is null)
            {
                this.AddNotification("card", "card is Required");
            }

            if (this.IsInvalid())
                return null;

            var url = await MPUrlBuildAsync($"/v1/customers/{card.CustomerId}/cards/");
            var stringContent = JsonConvert.SerializeObject(card, MPUtil.JsonSerializerSettings);
            var content = new StringContent(stringContent, Encoding.UTF8, "application/json");
            var response = await Client.PostAsync(url, content);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            return JsonConvert.DeserializeObject<Card>(stringResponse, MPUtil.JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<Card> UpdateAsync(Card card)
        {
            if (card is null)
            {
                this.AddNotification("card", "card is Required");
            }

            if (this.IsInvalid())
                return null;

            var url = await MPUrlBuildAsync($"/v1/customers/{card.CustomerId}/cards/{card.Id}");
            var content = new StringContent(JsonConvert.SerializeObject(card, MPUtil.JsonSerializerSettings), Encoding.UTF8, "application/json");
            var response = await Client.PutAsync(url, content);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            return JsonConvert.DeserializeObject<Card>(stringResponse, MPUtil.JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<Card> DeleteAsync(Card card)
        {
            if (card is null)
            {
                this.AddNotification("card", "card is Required");
            }

            if (this.IsInvalid())
                return null;

            var url = await MPUrlBuildAsync($"/v1/customers/{card.CustomerId}/cards/{card.Id}");
            var response = await Client.DeleteAsync(url);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            return JsonConvert.DeserializeObject<Card>(stringResponse, MPUtil.JsonSerializerSettings);
        }
    }
}
