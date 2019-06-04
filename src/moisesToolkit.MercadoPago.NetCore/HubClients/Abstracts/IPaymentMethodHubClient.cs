﻿using System.Collections.Generic;
using System.Threading.Tasks;
using MercadoPago.NetCore.Model.Resources;

namespace moisesToolkit.MercadoPago.NetCore
{
    public interface IPaymentMethodHubClient
    {
        Task<List<PaymentMethod>> GetPaymentMethods();
    }
}