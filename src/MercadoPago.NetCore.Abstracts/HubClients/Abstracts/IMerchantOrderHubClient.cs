using System.Threading.Tasks;
using MercadoPago.NetCore.Model.Resources;
using prmToolkit.NotificationPattern;

namespace Moises.Toolkit.MercadoPago.NetCore.HubClients.Abstracts
{
    public interface IMerchantOrderHubClient : INotifiable
    {
        Task<MerchantOrder> FindAsync(string merchantOrderId);
        Task<MerchantOrder> SaveAsync(MerchantOrder merchantOrder);
        Task<MerchantOrder> UpdateAsync(MerchantOrder merchantOrder);
    }
}