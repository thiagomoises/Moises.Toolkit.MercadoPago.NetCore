using System.Collections.Generic;
using System.Threading.Tasks;
using MercadoPago.NetCore.Model.Resources;

namespace moisesToolkit.MercadoPago.NetCore.HubClients.Abstracts
{
    public interface IPaymentMethodHubClient
    {
        Task<List<PaymentMethod>> GetPaymentMethods();
    }
}