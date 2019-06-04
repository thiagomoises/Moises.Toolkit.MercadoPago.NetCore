using MercadoPago.NetCore.Model.Resources.Dataclassures.Auth;
using moisesToolkit.MercadoPago.NetCore.HubClients.Abstracts;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;

namespace moisesToolkit.MercadoPago.NetCore.HubClients
{
    public class TokenHubClient : ITokenHubClient
    {
        protected readonly HttpClient Client;
        private readonly MPOptions _options;

        public TokenHubClient(HttpClient httpClient, MPOptions options)
        {
            httpClient.BaseAddress = new Uri("https://api.mercadopago.com");
            httpClient.DefaultRequestHeaders.Add("ContentType", "application/json");
            httpClient.DefaultRequestHeaders.Add("User-Agent", "MercadoPago DotNet SDK/1.0.30");
            Client = httpClient;
            _options = options;
        }

        public async System.Threading.Tasks.Task<Ticket> GetTicketAsync()
        {
            var requestObject = new { grant_type = "client_credentials", client_id = _options.ClientId, client_secret = _options.ClientSecret };
            var content = new StringContent(JsonConvert.SerializeObject(requestObject), Encoding.UTF8, "application/json");
            var response = await Client.PostAsync("/oauth/token", content);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Ticket>(stringResponse, MPUtil.JsonSerializerSettings);
        }
    }
}
