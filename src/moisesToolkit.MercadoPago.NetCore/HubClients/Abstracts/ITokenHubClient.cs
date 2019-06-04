using System.Threading.Tasks;
using MercadoPago.NetCore.Model.Resources.Dataclassures.Auth;

namespace moisesToolkit.MercadoPago.NetCore.HubClients.Abstracts
{
    public interface ITokenHubClient
    {
        Task<Ticket> GetTicketAsync();
    }
}