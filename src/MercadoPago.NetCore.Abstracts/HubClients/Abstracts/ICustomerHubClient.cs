using System.Collections.Generic;
using System.Threading.Tasks;
using MercadoPago.NetCore.Model.DataStructures.Search;
using MercadoPago.NetCore.Model.Resources;
using prmToolkit.NotificationPattern;

namespace Moises.Toolkit.MercadoPago.NetCore.HubClients.Abstracts
{
    public interface ICustomerHubClient : INotifiable
    {
        Task<Customer> DeleteAsync(Customer customer);
        Task<Customer> FindAsync(string customerId);
        Task<Customer> SaveAsync(Customer customer);
        Task<SearchResult<Customer>> SearchAsync(Dictionary<string, string> mapParams);
        Task<Customer> UpdateAsync(Customer customer);
    }
}