using System.Threading.Tasks;
using MercadoPago.NetCore.Model.Resources;

namespace moisesToolkit.MercadoPago.NetCore.HubClients
{
    public interface IPlanHubClient
    {
        Task<Plan> FindAsync(string planId);
        Task<Plan> SaveAsync(Plan plan);
        Task<Plan> UpdateAsync(Plan plan);
    }
}