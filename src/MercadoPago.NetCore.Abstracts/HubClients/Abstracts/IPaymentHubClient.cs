using System.Collections.Generic;
using System.Threading.Tasks;
using MercadoPago.NetCore.Model.DataStructures.Search;
using MercadoPago.NetCore.Model.Resources;
using prmToolkit.NotificationPattern;

namespace Moises.Toolkit.MercadoPago.NetCore.HubClients.Abstracts
{
    public interface IPaymentHubClient : INotifiable
    {
        Task<Payment> FindAsync(string paymentId);
        Task<List<Payment>> GetPaymentsAsync();
        Task<Payment> SaveAsync(Payment payment);
        Task<SearchResult<Payment>> SearchAsync(Dictionary<string, string> mapParams);
        Task<Payment> UpdateAsync(Payment payment);
    }
}