﻿using MercadoPago.NetCore.Model.Resources;
using moisesToolkit.MercadoPago.NetCore.HubClients.Abstracts;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace moisesToolkit.MercadoPago.NetCore.HubClients
{
    public class RefundHubClient : MercadoPagoHubClient, IRefundHubClient
    {
        public RefundHubClient(HttpClient httpClient, MPOptions options, ITokenHubClient tokenHubClient) : base(httpClient, options, tokenHubClient)
        {
        }

        public async System.Threading.Tasks.Task<Refund> SaveAsync(Refund refund)
        {
            if (refund is null)
            {
                this.AddNotification("refund", "refund is Required");
            }

            if (this.IsInvalid())
                return null;

            var url = await MPUrlBuildAsync($"/v1/payments/{refund.PaymentId}/refunds");
            var content = new StringContent(JsonConvert.SerializeObject(refund, MPUtil.JsonSerializerSettings), Encoding.UTF8, "application/json");
            var response = await Client.PostAsync(url, content);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            return JsonConvert.DeserializeObject<Refund>(stringResponse, MPUtil.JsonSerializerSettings);
        }

    }
}
