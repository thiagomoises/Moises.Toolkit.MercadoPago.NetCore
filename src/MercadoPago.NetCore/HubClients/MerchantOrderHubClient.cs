using MercadoPago.NetCore.Model.Resources;
using Moises.Toolkit.MercadoPago.NetCore.HubClients;
using Moises.Toolkit.MercadoPago.NetCore.HubClients.Abstracts;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Moises.Toolkit.MercadoPago.NetCore
{
    public partial class MerchantOrderHubClient : MercadoPagoHubClient, IMerchantOrderHubClient
    {
        public MerchantOrderHubClient(IHttpClientFactory httpClientFactory, MPOptions options, ITokenHubClient tokenHubClient) : base(httpClientFactory, options, tokenHubClient)
        {
        }

        public async System.Threading.Tasks.Task<MerchantOrder> FindAsync(string merchantOrderId)
        {
            if (string.IsNullOrEmpty(merchantOrderId))
            {
                this.AddNotification("merchantOrderId", "merchantOrderId is Required");
            }

            if (this.IsInvalid())
                return null;

            var url = await MPUrlBuildAsync($"/v1/merchant_orders/{merchantOrderId}");
            var response = await Client.GetAsync(url);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            return JsonConvert.DeserializeObject<MerchantOrder>(stringResponse, MPUtil.JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<MerchantOrder> SaveAsync(MerchantOrder merchantOrder)
        {
            if (merchantOrder is null)
            {
                this.AddNotification("merchantOrder", "merchantOrder is Required");
            }

            if (this.IsInvalid())
                return null;

            var url = await MPUrlBuildAsync($"/v1/merchant_orders/");

            var content = new StringContent(JsonConvert.SerializeObject(merchantOrder, MPUtil.JsonSerializerSettings), Encoding.UTF8, "application/json");
            var response = await Client.PostAsync(url, content);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            return JsonConvert.DeserializeObject<MerchantOrder>(stringResponse, MPUtil.JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<MerchantOrder> UpdateAsync(MerchantOrder merchantOrder)
        {
            if (merchantOrder is null)
            {
                this.AddNotification("merchantOrder", "merchantOrder is Required");
            }

            if (this.IsInvalid())
                return null;

            var url = await MPUrlBuildAsync($"/v1/merchant_orders/{merchantOrder.Id}/");
            var content = new StringContent(JsonConvert.SerializeObject(merchantOrder, MPUtil.JsonSerializerSettings), Encoding.UTF8, "application/json");
            var response = await Client.PutAsync(url, content);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            return JsonConvert.DeserializeObject<MerchantOrder>(stringResponse, MPUtil.JsonSerializerSettings);
        }
    }
}
