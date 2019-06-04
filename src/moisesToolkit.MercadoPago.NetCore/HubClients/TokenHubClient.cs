using MercadoPago.NetCore.Model.Resources.Dataclassures.Auth;
using moisesToolkit.MercadoPago.NetCore.HubClients.Abstracts;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace moisesToolkit.MercadoPago.NetCore.HubClients
{
    public class TokenHubClient : ITokenHubClient
    {
        protected readonly HttpClient Client;
        private readonly MPOptions _options;

        public TokenHubClient(IHttpClientFactory httpClientFactory, MPOptions options)
        {
            Client = httpClientFactory.CreateClient("mercadopago");
            _options = options;
        }

        public async System.Threading.Tasks.Task<Ticket> GetTicketAsync()
        {
            if (_options.UseSandbox)
            {
                return new Ticket()
                {
                    AccessToken = _options.SandboxAccessToken,
                    ExpiresIn = 360
                };
            }
            else
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
}
