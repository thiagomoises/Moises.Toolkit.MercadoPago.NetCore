using System.Collections.Generic;
using System.Threading.Tasks;
using MercadoPago.NetCore.Model.Resources;

namespace moisesToolkit.MercadoPago.NetCore.HubClients.Abstracts
{
    public interface IPreferenceHubClient
    {
        Task<Preference> FindAsync(string preferenceId);
        Task<Preference> SaveAsync(Preference preference);
        Task<Preference> UpdateAsync(Preference preference);
    }
}