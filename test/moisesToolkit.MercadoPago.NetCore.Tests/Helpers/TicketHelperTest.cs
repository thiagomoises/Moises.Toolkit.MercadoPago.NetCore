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
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://api.mercadopago.com");
            httpClient.DefaultRequestHeaders.Add("ContentType", "application/json");
            httpClient.DefaultRequestHeaders.Add("User-Agent", "MercadoPago DotNet SDK/1.0.30");
            return httpClient;
        }
        public static MPOptions GetMPOptions()
        {
            var x = new MPOptions()
            {
                ClientId = "701342797733779",
                ClientSecret = "uyjunhCODZnR7LNPykouD076Eig74hF8",
            };
            x.UseSandboxAccessToken("TEST-8600607042428103-060407-f91bbb3d5d0029bc342657a83aa08ee5-397002962");
            return x;
        }
    }
}
