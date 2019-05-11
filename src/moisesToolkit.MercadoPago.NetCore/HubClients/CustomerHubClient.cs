using MercadoPago.NetCore.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace moisesToolkit.MercadoPago.NetCore
{
    public partial class CustomerHubClient : MercadoPagoHubClient
    {
        public CustomerHubClient(HttpClient httpClient, MPOptions options) : base(httpClient, options)
        {
        }

        public async System.Threading.Tasks.Task<List<Customer>> SearchAsync(Dictionary<string, string> mapParams)
        {
            var url = await MPUrlBuildAsync($"/v1/customers/search", mapParams);
            var response = await Client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Customer>>(stringResponse, JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<Customer> FindAsync(string customerId)
        {
            var url = await MPUrlBuildAsync($"/v1/customers/{customerId}");
            var response = await Client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Customer>(stringResponse, JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<bool> SaveAsync(Customer customer)
        {
            var url = await MPUrlBuildAsync($"/v1/customers/");

            var content = new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json");
            var response = await Client.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            return true;
        }

        public async System.Threading.Tasks.Task<bool> UpdateAsync(Customer customer)
        {
            var url = await MPUrlBuildAsync($"/v1/customers/{customer.Id}/");
            var content = new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json");
            var response = await Client.PutAsync(url, content);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            return true;
        }

        public async System.Threading.Tasks.Task<List<Customer>> DeleteAsync(Customer customer)
        {
            var url = await MPUrlBuildAsync($"/v1/customers/{customer.Id}");
            var response = await Client.DeleteAsync(url);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Customer>>(stringResponse, JsonSerializerSettings);
        }
    }
}
