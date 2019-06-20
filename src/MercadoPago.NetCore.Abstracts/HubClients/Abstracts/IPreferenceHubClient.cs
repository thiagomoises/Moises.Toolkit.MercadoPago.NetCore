using System.Collections.Generic;
using System.Threading.Tasks;
using MercadoPago.NetCore.Model.Resources;
using prmToolkit.NotificationPattern;

namespace Moises.Toolkit.MercadoPago.NetCore.HubClients.Abstracts
{
    public interface IPreferenceHubClient : INotifiable
    {
        Task<Preference> FindAsync(string preferenceId);
        Task<Preference> SaveAsync(Preference preference);
        Task<Preference> UpdateAsync(Preference preference);
    }
}