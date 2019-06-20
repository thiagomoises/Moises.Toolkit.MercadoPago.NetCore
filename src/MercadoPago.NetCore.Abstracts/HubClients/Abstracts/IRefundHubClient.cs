using System.Threading.Tasks;
using MercadoPago.NetCore.Model.Resources;
using prmToolkit.NotificationPattern;

namespace Moises.Toolkit.MercadoPago.NetCore.HubClients.Abstracts
{
    public interface IRefundHubClient : INotifiable
    {
        Task<Refund> SaveAsync(Refund refund);
    }
}