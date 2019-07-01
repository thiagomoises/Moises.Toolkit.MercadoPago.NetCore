using System.Collections.Generic;
using System.Threading.Tasks;
using MercadoPago.NetCore.Model.DataStructures.Search;
using MercadoPago.NetCore.Model.Resources;
using prmToolkit.NotificationPattern;

namespace Moises.Toolkit.MercadoPago.NetCore.HubClients.Abstracts
{
    public interface ICardsHubClient : INotifiable
    {
        Task<Card> DeleteAsync(Card card);
        Task<Card> FindAsync(string customerId, string cardId);
        Task<IEnumerable<Card>> GetCardsAsync(string customerId);
        Task<Card> SaveAsync(Card card);
        Task<Card> UpdateAsync(Card card);
    }
}