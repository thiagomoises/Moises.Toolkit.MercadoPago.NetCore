using System.Collections.Generic;
using System.Threading.Tasks;
using MercadoPago.NetCore.Model.DataStructures.Search;
using MercadoPago.NetCore.Model.Resources;
using prmToolkit.NotificationPattern;

namespace Moises.Toolkit.MercadoPago.NetCore.HubClients.Abstracts
{
    public interface IPreapprovalHubClient : INotifiable
    {
        Task<Preapproval> FindAsync(string preapprovalId);
        Task<Preapproval> SaveAsync(Preapproval preapproval);
        Task<SearchResult<Preapproval>> SearchAsync(Dictionary<string, string> mapParams);
        Task<Preapproval> UpdateAsync(Preapproval preapproval);
    }
}