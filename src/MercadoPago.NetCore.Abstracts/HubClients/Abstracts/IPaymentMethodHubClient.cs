using System.Collections.Generic;
using System.Threading.Tasks;
using MercadoPago.NetCore.Model.Resources;
using prmToolkit.NotificationPattern;

namespace Moises.Toolkit.MercadoPago.NetCore.HubClients.Abstracts
{
    public interface IPaymentMethodHubClient : INotifiable
    {
        Task<List<PaymentMethod>> GetPaymentMethods();
    }
}