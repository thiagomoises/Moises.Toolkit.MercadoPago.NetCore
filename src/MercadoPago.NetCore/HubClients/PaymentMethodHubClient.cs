using MercadoPago.NetCore.Model.Resources;
using Moises.Toolkit.MercadoPago.NetCore.HubClients;
using Moises.Toolkit.MercadoPago.NetCore.HubClients.Abstracts;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;

namespace Moises.Toolkit.MercadoPago.NetCore
{
    public partial class PaymentMethodHubClient : MercadoPagoHubClient, IPaymentMethodHubClient
    {
        public PaymentMethodHubClient(IHttpClientFactory httpClientFactory, MPOptions options, ITokenHubClient tokenHubClient) : base(httpClientFactory, options, tokenHubClient)
        {
        }

        public async System.Threading.Tasks.Task<List<PaymentMethod>> GetPaymentMethods()
        {
            var url = await MPUrlBuildAsync($"/v1/payment_methods");
            var response = await Client.GetAsync(url);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            return JsonConvert.DeserializeObject<List<PaymentMethod>>(stringResponse, MPUtil.JsonSerializerSettings);
        }
    }
}
