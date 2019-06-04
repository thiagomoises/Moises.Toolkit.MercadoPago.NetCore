﻿using System.Threading.Tasks;
using MercadoPago.NetCore.Model.Resources;

namespace moisesToolkit.MercadoPago.NetCore
{
    public interface IMerchantOrderHubClient
    {
        Task<MerchantOrder> FindAsync(string merchantOrderId);
        Task<MerchantOrder> SaveAsync(MerchantOrder merchantOrder);
        Task<MerchantOrder> UpdateAsync(MerchantOrder merchantOrder);
    }
}