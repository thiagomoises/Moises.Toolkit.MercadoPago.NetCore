using System.Threading.Tasks;
using MercadoPago.NetCore.Model.Resources;

namespace moisesToolkit.MercadoPago.NetCore.HubClients.Abstracts
{
    public interface IRefundHubClient
    {
        Task<Refund> SaveAsync(Refund refund);
    }
}