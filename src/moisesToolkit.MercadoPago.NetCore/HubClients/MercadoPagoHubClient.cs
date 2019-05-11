using MercadoPago.NetCore.Model.DataStructures.Auth;
using moisesToolkit.MercadoPago.NetCore.JsonMaps;
using Newtonsoft.FluentAPI.Resolvers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace moisesToolkit.MercadoPago.NetCore
{
    public abstract class MercadoPagoHubClient
    {
        #region Static properties
        protected static JsonSerializerSettings JsonSerializerSettings { get; private set; }
        protected static Ticket ActualTicket { get; set; }
        #endregion

        protected readonly HttpClient Client;
        private readonly MPOptions _options;

        public MercadoPagoHubClient(HttpClient httpClient, MPOptions options)
        {
            httpClient.BaseAddress = new Uri("https://api.mercadopago.com");
            httpClient.DefaultRequestHeaders.Add("ContentType", "application/json");
            httpClient.DefaultRequestHeaders.Add("User-Agent", "MercadoPago DotNet SDK/1.0.30");
            Client = httpClient;
            _options = options;
            this.ConfigureSerializerSettings();
        }


        private void ConfigureSerializerSettings()
        {
            FluentContractResolver _fcr = new FluentContractResolver();
            _fcr.AddConfiguration(new TicketMap());

            JsonSerializerSettings = new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore,
                DefaultValueHandling = DefaultValueHandling.Ignore,
                Formatting = Formatting.Indented,
                ContractResolver = _fcr
            };
        }

        private async Task RefreshAccessTokenAsync()
        {
            if (ActualTicket.IsExpired == true)
            {
                var requestObject = new { grant_type = "client_credentials", client_id = _options.ClientId, client_secret = _options.ClientSecret };
                var content = new StringContent(JsonConvert.SerializeObject(requestObject), Encoding.UTF8, "application/json");
                var response = await Client.PostAsync("/oauth/token", content);
                response.EnsureSuccessStatusCode();
                var stringResponse = await response.Content.ReadAsStringAsync();
                ActualTicket = JsonConvert.DeserializeObject<Ticket>(stringResponse, JsonSerializerSettings);
            }
        }

        protected async Task<string> MPUrlBuildAsync(string baseUrl)
        {
            await this.RefreshAccessTokenAsync();
            return string.Format("{0}{1}{2}", baseUrl, "?access_token=", ActualTicket.AccessToken);
        }

        protected async Task<string> MPUrlBuildAsync(string baseUrl, Dictionary<string,string> mapParams)
        {
            var url = await this.MPUrlBuildAsync(baseUrl);
            StringBuilder paramsSb = new StringBuilder();
            foreach (var elem in mapParams)
            {
                paramsSb.Append(string.Format("{0}{1}={2}", "&", elem.Key, elem.Value));
            }
            return string.Format("{0}{1}", url, paramsSb.ToString());
        }

    }
}
