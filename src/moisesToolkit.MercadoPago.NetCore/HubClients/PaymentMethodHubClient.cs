using MercadoPago.NetCore.Model.Resources;
using moisesToolkit.MercadoPago.NetCore.HubClients;
using moisesToolkit.MercadoPago.NetCore.HubClients.Abstracts;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;

namespace moisesToolkit.MercadoPago.NetCore
{
    public partial class PaymentMethodHubClient : MercadoPagoHubClient
    {
        public PaymentMethodHubClient(HttpClient httpClient, MPOptions options, ITokenHubClient tokenHubClient) : base(httpClient, options, tokenHubClient)
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
