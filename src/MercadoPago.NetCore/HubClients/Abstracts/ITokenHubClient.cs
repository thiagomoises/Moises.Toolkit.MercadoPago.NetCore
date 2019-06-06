using MercadoPago.NetCore.Model.Resources.Dataclassures.Auth;
using System.Threading.Tasks;

namespace Moises.Toolkit.MercadoPago.NetCore.HubClients.Abstracts
{
    public interface ITokenHubClient
    {
        Task<Ticket> GetTicketAsync();
    }
}