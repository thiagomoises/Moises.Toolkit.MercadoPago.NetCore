using MercadoPago.NetCore.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace moisesToolkit.MercadoPago.NetCore
{
    public partial class CardsHubClient : MercadoPagoHubClient
    {
        public CardsHubClient(HttpClient httpClient, MPOptions options) : base(httpClient, options)
        {
        }

        public async System.Threading.Tasks.Task<List<Card>> GetCardsAsync(string customerId)
        {
            var url = await MPUrlBuildAsync($"/v1/customers/{customerId}/cards");
            var response = await Client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Card>>(stringResponse, JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<Card> FindAsync(string customerId, string cardId)
        {
            var url = await MPUrlBuildAsync($"/v1/customers/{customerId}/cards/{cardId}");
            var response = await Client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Card>(stringResponse, JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<bool> SaveAsync(Card card)
        {
            var url = await MPUrlBuildAsync($"/v1/customers/{card.CustomerId}/cards/");

            var content = new StringContent(JsonConvert.SerializeObject(card), Encoding.UTF8, "application/json");
            var response = await Client.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            return true;
        }

        public async System.Threading.Tasks.Task<bool> UpdateAsync(Card card)
        {
            var url = await MPUrlBuildAsync($"/v1/customers/{card.CustomerId}/cards/{card.Id}");
            var content = new StringContent(JsonConvert.SerializeObject(card), Encoding.UTF8, "application/json");
            var response = await Client.PutAsync(url, content);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            return true;
        }

        public async System.Threading.Tasks.Task<List<Card>> DeleteAsync(Card card)
        {
            var url = await MPUrlBuildAsync($"/v1/customers/{card.CustomerId}/cards/{card.Id}");
            var response = await Client.DeleteAsync(url);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Card>>(stringResponse, JsonSerializerSettings);
        }
    }
}
