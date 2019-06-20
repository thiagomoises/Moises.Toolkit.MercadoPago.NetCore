using System.Threading.Tasks;
using MercadoPago.NetCore.Model.Resources;
using prmToolkit.NotificationPattern;

namespace Moises.Toolkit.MercadoPago.NetCore.HubClients.Abstracts
{
    public interface IPlanHubClient : INotifiable
    {
        Task<Plan> FindAsync(string planId);
        Task<Plan> SaveAsync(Plan plan);
        Task<Plan> UpdateAsync(Plan plan);
    }
}