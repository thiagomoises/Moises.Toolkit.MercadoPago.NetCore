using System.Threading.Tasks;
using MercadoPago.NetCore.Model.DataStructures.Search;
using MercadoPago.NetCore.Model.Resources;

namespace moisesToolkit.MercadoPago.NetCore.HubClients.Abstracts
{
    public interface ICardsHubClient
    {
        Task<Card> DeleteAsync(Card card);
        Task<Card> FindAsync(string customerId, string cardId);
        Task<SearchResult<Card>> GetCardsAsync(string customerId);
        Task<Card> SaveAsync(Card card);
        Task<Card> UpdateAsync(Card card);
    }
}