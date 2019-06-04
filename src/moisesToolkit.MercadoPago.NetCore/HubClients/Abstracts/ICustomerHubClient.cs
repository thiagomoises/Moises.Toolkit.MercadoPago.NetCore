using System.Collections.Generic;
using System.Threading.Tasks;
using MercadoPago.NetCore.Model.DataStructures.Search;
using MercadoPago.NetCore.Model.Resources;

namespace moisesToolkit.MercadoPago.NetCore.HubClients
{
    public interface ICustomerHubClient
    {
        Task<Customer> DeleteAsync(Customer customer);
        Task<Customer> FindAsync(string customerId);
        Task<Customer> SaveAsync(Customer customer);
        Task<SearchResult<Customer>> SearchAsync(Dictionary<string, string> mapParams);
        Task<Customer> UpdateAsync(Customer customer);
    }
}