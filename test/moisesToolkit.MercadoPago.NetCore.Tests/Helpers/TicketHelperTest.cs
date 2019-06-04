using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace moisesToolkit.MercadoPago.NetCore.Tests.Helpers
{
    public static class TicketHelperTest
    {
        public static HttpClient GetHttpClient()
        {
            return new HttpClient();
        }
        public static MPOptions GetMPOptions()
        {
            return new MPOptions()
            {
                ClientId = "701342797733779",
                ClientSecret = "uyjunhCODZnR7LNPykouD076Eig74hF8"
            };
        }
    }
}
