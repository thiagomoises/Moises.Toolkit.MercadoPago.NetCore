using System.Collections.Generic;
using System.Threading.Tasks;
using MercadoPago.NetCore.Model.DataStructures.Search;
using MercadoPago.NetCore.Model.Resources;

namespace moisesToolkit.MercadoPago.NetCore.HubClients.Abstracts
{
    public interface IPreapprovalHubClient
    {
        Task<Preapproval> FindAsync(string preapprovalId);
        Task<Preapproval> SaveAsync(Preapproval preapproval);
        Task<SearchResult<Preapproval>> SearchAsync(Dictionary<string, string> mapParams);
        Task<Preapproval> UpdateAsync(Preapproval preapproval);
    }
}