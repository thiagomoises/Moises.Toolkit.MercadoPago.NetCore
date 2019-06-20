using AutoMapper;
using MercadoPago.NetCore.Model.DataStructures.Search;
using MercadoPago.NetCore.Model.Resources;
using MercadoPago.NetCore.Request;
using Moises.Toolkit.MercadoPago.NetCore.HubClients;
using Moises.Toolkit.MercadoPago.NetCore.HubClients.Abstracts;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Moises.Toolkit.MercadoPago.NetCore
{
    public partial class PaymentHubClient : MercadoPagoHubClient, IPaymentHubClient
    {
        private readonly IMapper _mapper;
        public PaymentHubClient(IMapper mapper, IHttpClientFactory httpClientFactory, MPOptions options, ITokenHubClient tokenHubClient) : base(httpClientFactory, options, tokenHubClient)
        {
            _mapper = mapper;
        }

        public async System.Threading.Tasks.Task<List<Payment>> GetPaymentsAsync()
        {
            var url = await MPUrlBuildAsync($"/v1/payments/search");
            var response = await Client.GetAsync(url);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            return JsonConvert.DeserializeObject<List<Payment>>(stringResponse, MPUtil.JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<SearchResult<Payment>> SearchAsync(Dictionary<string, string> mapParams)
        {
            var url = await MPUrlBuildAsync($"/v1/payments/search", mapParams);
            var response = await Client.GetAsync(url);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            return JsonConvert.DeserializeObject<SearchResult<Payment>>(stringResponse, MPUtil.JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<Payment> FindAsync(string paymentId)
        {
            if (string.IsNullOrEmpty(paymentId))
            {
                this.AddNotification("paymentId", "paymentId is Required");
            }

            if (this.IsInvalid())
                return null;

            var url = await MPUrlBuildAsync($"/v1/payments/{paymentId}");
            var response = await Client.GetAsync(url);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            return JsonConvert.DeserializeObject<Payment>(stringResponse, MPUtil.JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<Payment> SaveAsync(Payment payment)
        {
            if (payment is null)
            {
                this.AddNotification("payment", "payment is Required");
            }

            if (this.IsInvalid())
                return null;

            var paymentRequest = _mapper.Map<PaymentRequest>(payment);

            var url = await MPUrlBuildAsync($"/v1/payments/");

            var content = new StringContent(JsonConvert.SerializeObject(paymentRequest, MPUtil.JsonSerializerSettings), Encoding.UTF8, "application/json");
            var response = await Client.PostAsync(url, content);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            return JsonConvert.DeserializeObject<Payment>(stringResponse, MPUtil.JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<Payment> UpdateAsync(Payment payment)
        {
            if (payment is null)
            {
                this.AddNotification("payment", "payment is Required");
            }

            if (this.IsInvalid())
                return null;

            var url = await MPUrlBuildAsync($"/v1/payments/{payment.Id}/");
            var content = new StringContent(JsonConvert.SerializeObject(payment, MPUtil.JsonSerializerSettings), Encoding.UTF8, "application/json");
            var response = await Client.PutAsync(url, content);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            return JsonConvert.DeserializeObject<Payment>(stringResponse, MPUtil.JsonSerializerSettings);
        }
    }
}
