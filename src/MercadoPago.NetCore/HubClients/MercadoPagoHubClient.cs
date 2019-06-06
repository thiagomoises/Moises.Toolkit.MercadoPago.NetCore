using MercadoPago.NetCore.Model.Resources.Dataclassures.Auth;
using MercadoPago.NetCore.Model.Resources.Errors;
using Moises.Toolkit.MercadoPago.NetCore.HubClients.Abstracts;
using Newtonsoft.Json;
using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Moises.Toolkit.MercadoPago.NetCore.HubClients
{
    public abstract class MercadoPagoHubClient : Notifiable
    {
        #region Static properties
        protected static Ticket ActualTicket { get; set; }
        #endregion

        protected readonly HttpClient Client;
        private readonly MPOptions _options;
        private readonly ITokenHubClient _tokenHubService;

        public MercadoPagoHubClient(IHttpClientFactory httpClientFactory, MPOptions options, ITokenHubClient tokenHubService)
        {            
            Client = httpClientFactory.CreateClient("mercadopago");
            _options = options;
            _tokenHubService = tokenHubService;
        }

        protected async Task<string> ExtractResponseAsync(HttpResponseMessage response)
        {
            var stringResponse = await response.Content.ReadAsStringAsync();
            if (new HttpStatusCode[] { HttpStatusCode.BadRequest, HttpStatusCode.InternalServerError }.Contains(response.StatusCode))
            {
                var errorResult = JsonConvert.DeserializeObject<ErrorResult>(stringResponse, MPUtil.JsonSerializerSettings);
                foreach (var cause in errorResult.Causes)
                {
                    this.AddNotification(cause.Code, cause.Description);
                }
            }
            return stringResponse;
        }

        private async Task RefreshAccessTokenAsync()
        {
            if (ActualTicket?.IsExpired != true)
            {
                ActualTicket = await _tokenHubService.GetTicketAsync();
            }
        }

        protected async Task<string> MPUrlBuildAsync(string baseUrl)
        {
            await this.RefreshAccessTokenAsync();
            return string.Format("{0}{1}{2}", baseUrl, "?access_token=", ActualTicket.AccessToken);
        }

        protected async Task<string> MPUrlBuildAsync(string baseUrl, Dictionary<string, string> mapParams)
        {
            var url = await this.MPUrlBuildAsync(baseUrl);
            StringBuilder paramsSb = new StringBuilder();
            if (mapParams != null)
            {
                foreach (var elem in mapParams)
                {
                    paramsSb.Append(string.Format("{0}{1}={2}", "&", elem.Key, elem.Value));
                }
            }
            return string.Format("{0}{1}", url, paramsSb.ToString());
        }

    }
}
