using Moises.Toolkit.MercadoPago.NetCore.JsonMaps;
using Newtonsoft.FluentAPI.Resolvers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moises.Toolkit.MercadoPago.NetCore
{
    public static class MPUtil
    {
        public static JsonSerializerSettings JsonSerializerSettings { get; private set; }

        static MPUtil()
        {
            ConfigureSerializerSettings();
        }

        private static void ConfigureSerializerSettings()
        {
            FluentContractResolver _fcr = new FluentContractResolver();
            _fcr.AddConfiguration(new TicketMap());
            _fcr.AddConfiguration(new CardMap());
            _fcr.AddConfiguration(new JsonMaps.Cards.HolderCardMap());
            _fcr.AddConfiguration(new JsonMaps.Cards.IdentificationMap());
            _fcr.AddConfiguration(new JsonMaps.Cards.IssuerMap());
            _fcr.AddConfiguration(new JsonMaps.Cards.SecuryCodeMap());
            _fcr.AddConfiguration(new CustomerMap());
            _fcr.AddConfiguration(new Moises.Toolkit.MercadoPago.NetCore.JsonMaps.Costumers.AddressMap());
            _fcr.AddConfiguration(new Moises.Toolkit.MercadoPago.NetCore.JsonMaps.Costumers.IdentificationMap());
            _fcr.AddConfiguration(new Moises.Toolkit.MercadoPago.NetCore.JsonMaps.Costumers.PhoneMap());
            _fcr.AddConfiguration(new MerchantOrderMap());
            _fcr.AddConfiguration(new Moises.Toolkit.MercadoPago.NetCore.JsonMaps.MerchantOrders.AddressMap());
            _fcr.AddConfiguration(new Moises.Toolkit.MercadoPago.NetCore.JsonMaps.MerchantOrders.CollectorMap());
            _fcr.AddConfiguration(new Moises.Toolkit.MercadoPago.NetCore.JsonMaps.MerchantOrders.PayerMap());
            _fcr.AddConfiguration(new Moises.Toolkit.MercadoPago.NetCore.JsonMaps.MerchantOrders.MerchantOrderPaymentMap());
            _fcr.AddConfiguration(new Moises.Toolkit.MercadoPago.NetCore.JsonMaps.MerchantOrders.ShipmentMap());
            _fcr.AddConfiguration(new PaymentMethodMap());
            _fcr.AddConfiguration(new Moises.Toolkit.MercadoPago.NetCore.JsonMaps.PaymentMethods.BinMap());
            _fcr.AddConfiguration(new Moises.Toolkit.MercadoPago.NetCore.JsonMaps.PaymentMethods.CardNumberMap());
            _fcr.AddConfiguration(new Moises.Toolkit.MercadoPago.NetCore.JsonMaps.PaymentMethods.SecuryCodeMap());
            _fcr.AddConfiguration(new Moises.Toolkit.MercadoPago.NetCore.JsonMaps.PaymentMethods.SettingsMap());
            _fcr.AddConfiguration(new PaymentMap());
            _fcr.AddConfiguration(new Moises.Toolkit.MercadoPago.NetCore.JsonMaps.Payments.IdentificationMap());
            _fcr.AddConfiguration(new Moises.Toolkit.MercadoPago.NetCore.JsonMaps.Payments.PayerMap());
            _fcr.AddConfiguration(new Moises.Toolkit.MercadoPago.NetCore.JsonMaps.Payments.PhoneMap());
            _fcr.AddConfiguration(new Moises.Toolkit.MercadoPago.NetCore.JsonMaps.Payments.TransactionDetailMap());
            _fcr.AddConfiguration(new PlanMap());
            _fcr.AddConfiguration(new Moises.Toolkit.MercadoPago.NetCore.JsonMaps.Plans.AutoRecurringMap());
            _fcr.AddConfiguration(new Moises.Toolkit.MercadoPago.NetCore.JsonMaps.Plans.FreeTrialMap());
            _fcr.AddConfiguration(new PreapprovalMap());
            _fcr.AddConfiguration(new Moises.Toolkit.MercadoPago.NetCore.JsonMaps.Preapprovals.AutoRecurringMap());

            _fcr.AddConfiguration(new PreferenceMap());
            _fcr.AddConfiguration(new Moises.Toolkit.MercadoPago.NetCore.JsonMaps.Preferences.AddressMap());
            _fcr.AddConfiguration(new Moises.Toolkit.MercadoPago.NetCore.JsonMaps.Preferences.BackUrlsMap());
            _fcr.AddConfiguration(new Moises.Toolkit.MercadoPago.NetCore.JsonMaps.Preferences.PayerMap());
            _fcr.AddConfiguration(new Moises.Toolkit.MercadoPago.NetCore.JsonMaps.Preferences.ReceiverAddressMap());
            _fcr.AddConfiguration(new Moises.Toolkit.MercadoPago.NetCore.JsonMaps.Preferences.ShipmentMap());
            _fcr.AddConfiguration(new Moises.Toolkit.MercadoPago.NetCore.JsonMaps.Preferences.IdentificationMap());
            _fcr.AddConfiguration(new Moises.Toolkit.MercadoPago.NetCore.JsonMaps.Preferences.ItemMap());
            _fcr.AddConfiguration(new Moises.Toolkit.MercadoPago.NetCore.JsonMaps.Preferences.PaymentMethodsMap());
            _fcr.AddConfiguration(new Moises.Toolkit.MercadoPago.NetCore.JsonMaps.Preferences.PaymentMethodMap());
            _fcr.AddConfiguration(new Moises.Toolkit.MercadoPago.NetCore.JsonMaps.Preferences.PaymentTypeMap());

            _fcr.AddConfiguration(new SubscriptionMap());
            _fcr.AddConfiguration(new ErrorCauseMap());
            _fcr.AddConfiguration(new ErrorResultMap());

            JsonSerializerSettings = new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.Indented,
                ContractResolver = _fcr
            };
        }

    }
}
