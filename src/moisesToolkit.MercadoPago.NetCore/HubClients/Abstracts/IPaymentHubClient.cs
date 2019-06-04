using System.Collections.Generic;
using System.Threading.Tasks;
using MercadoPago.NetCore.Model.DataStructures.Search;
using MercadoPago.NetCore.Model.Resources;

namespace moisesToolkit.MercadoPago.NetCore
{
    public interface IPaymentHubClient
    {
        Task<Payment> FindAsync(string paymentId);
        Task<List<Payment>> GetPaymentsAsync();
        Task<Payment> SaveAsync(Payment payment);
        Task<SearchResult<Payment>> SearchAsync(Dictionary<string, string> mapParams);
        Task<Payment> UpdateAsync(Payment payment);
    }
}