using MercadoPago.NetCore.Model.DataStructures.Search;
using MercadoPago.NetCore.Model.Resources;
using MercadoPago.NetCore.Model.Resources.Errors;
using moisesToolkit.MercadoPago.NetCore.HubClients.Abstracts;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

namespace moisesToolkit.MercadoPago.NetCore.HubClients
{
    public partial class CustomerHubClient : MercadoPagoHubClient, ICustomerHubClient
    {
        public CustomerHubClient(IHttpClientFactory httpClientFactory, MPOptions options, ITokenHubClient tokenHubClient) : base(httpClientFactory, options, tokenHubClient)
        {
        }

        public async System.Threading.Tasks.Task<SearchResult<Customer>> SearchAsync(Dictionary<string, string> mapParams)
        {
            var url = await MPUrlBuildAsync($"/v1/customers/search", mapParams);
            var response = await Client.GetAsync(url);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            return JsonConvert.DeserializeObject<SearchResult<Customer>>(stringResponse, MPUtil.JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<Customer> FindAsync(string customerId)
        {
            if (string.IsNullOrEmpty(customerId))
            {
                this.AddNotification("Customer Id", "Is not can be null");
                return null;
            }

            var url = await MPUrlBuildAsync($"/v1/customers/{customerId}");
            var response = await Client.GetAsync(url);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            return JsonConvert.DeserializeObject<Customer>(stringResponse, MPUtil.JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<Customer> SaveAsync(Customer customer)
        {
            if (customer is null)
            {
                this.AddNotification("Customer", "Is not can be null");
                return null;
            }

            var url = await MPUrlBuildAsync($"/v1/customers/");
            var stringContent = JsonConvert.SerializeObject(customer, MPUtil.JsonSerializerSettings);

            var content = new StringContent(stringContent, Encoding.UTF8, "application/json");
            var response = await Client.PostAsync(url, content);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            this.ClearNotifications();
            return JsonConvert.DeserializeObject<Customer>(stringResponse, MPUtil.JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<Customer> UpdateAsync(Customer customer)
        {
            if (customer is null)
            {
                this.AddNotification("Customer", "Is not can be null");
                return null;
            }
            var url = await MPUrlBuildAsync($"/v1/customers/{customer.Id}/");
            var content = new StringContent(JsonConvert.SerializeObject(customer, MPUtil.JsonSerializerSettings), Encoding.UTF8, "application/json");
            var response = await Client.PutAsync(url, content);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            this.ClearNotifications();
            return JsonConvert.DeserializeObject<Customer>(stringResponse, MPUtil.JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<Customer> DeleteAsync(Customer customer)
        {
            if (customer is null)
            {
                this.AddNotification("Customer", "Is not can be null");
                return null;
            }
            var url = await MPUrlBuildAsync($"/v1/customers/{customer.Id}");
            var response = await Client.DeleteAsync(url);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            this.ClearNotifications();
            return JsonConvert.DeserializeObject<Customer>(stringResponse, MPUtil.JsonSerializerSettings);
        }
    }
}
