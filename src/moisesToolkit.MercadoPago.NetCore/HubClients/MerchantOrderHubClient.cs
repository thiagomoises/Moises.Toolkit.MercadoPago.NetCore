using MercadoPago.NetCore.Model.Resources;
using moisesToolkit.MercadoPago.NetCore.HubClients;
using moisesToolkit.MercadoPago.NetCore.HubClients.Abstracts;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace moisesToolkit.MercadoPago.NetCore
{
    public partial class MerchantOrderHubClient : MercadoPagoHubClient
    {
        public MerchantOrderHubClient(HttpClient httpClient, MPOptions options, ITokenHubClient tokenHubClient) : base(httpClient, options, tokenHubClient)
        {
        }

        public async System.Threading.Tasks.Task<MerchantOrder> FindAsync(string merchantOrderId)
        {
            var url = await MPUrlBuildAsync($"/v1/merchant_orders/{merchantOrderId}");
            var response = await Client.GetAsync(url);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            return JsonConvert.DeserializeObject<MerchantOrder>(stringResponse, MPUtil.JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<bool> SaveAsync(MerchantOrder merchantOrder)
        {
            var url = await MPUrlBuildAsync($"/v1/merchant_orders/");

            var content = new StringContent(JsonConvert.SerializeObject(merchantOrder, MPUtil.JsonSerializerSettings), Encoding.UTF8, "application/json");
            var response = await Client.PostAsync(url, content);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return false;
            return true;
        }

        public async System.Threading.Tasks.Task<bool> UpdateAsync(MerchantOrder merchantOrder)
        {
            var url = await MPUrlBuildAsync($"/v1/merchant_orders/{merchantOrder.Id}/");
            var content = new StringContent(JsonConvert.SerializeObject(merchantOrder, MPUtil.JsonSerializerSettings), Encoding.UTF8, "application/json");
            var response = await Client.PutAsync(url, content);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return false;
            return true;
        }
    }
}
